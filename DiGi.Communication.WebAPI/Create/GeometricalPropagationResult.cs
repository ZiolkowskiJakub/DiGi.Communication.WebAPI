using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.GeometricalPropagationResult"/> from the specified solved <see cref="GeometricalPropagationModel"/>.
        /// <para>The model must already have been solved (<see cref="ScatteringSolver"/> followed by <see cref="AngularPowerDistributionSolver"/>); this method only projects the calculation objects it holds into the result payload and never calculates anything itself.</para>
        /// </summary>
        /// <param name="geometricalPropagationModel">The solved geometrical propagation model. This value can be null.</param>
        /// <param name="transmitter">The location of the transmitter antenna in world coordinates. This value can be null.</param>
        /// <param name="receiver">The location of the receiver antenna in world coordinates. This value can be null.</param>
        /// <param name="minElevation">The elevation of the ground plane the propagation ellipsoid meshes are cut by, normally the lowest scattering object elevation.</param>
        /// <returns>A <see cref="Classes.GeometricalPropagationResult"/> grouped by delay (ascending), or null if the model or either antenna location is null, or if the model holds no delays to describe.</returns>
        public static Classes.GeometricalPropagationResult? GeometricalPropagationResult(this GeometricalPropagationModel? geometricalPropagationModel, Point3D? transmitter, Point3D? receiver, double minElevation)
        {
            // The antenna parameters carry no type name prefix and no underscore qualifier: CA1707
            // is enforced as an error in this project, so the DiGi _-suffixed qualifier convention
            // applies to locals only and never to externally visible parameter names.
            if (geometricalPropagationModel is null || transmitter is null || receiver is null)
            {
                return null;
            }

            // Everything below is expressed in world coordinates only, grouped by delay: the 3D
            // view drives a delay slider (ascending, General panel) and renders, for the selected
            // delay, the propagation ellipsoid(s), the scattering polylines (one per
            // ScatteringPointGroup, with the profile locations required for the auxiliary
            // polylines) and the angular power distribution vectors (scaled client side by the
            // user provided factor). See renderDelayResults in communication-tools.js.

            // Angular bins are sent as radians (as everything else in this payload); the matrix
            // form converts them to degrees for display. The mid value addresses the bin itself:
            // GetScatteringHits maps a single angle to one bin, whereas passing the bin bounds to
            // GetValues(Range, Range) can spill into the neighbouring bin.
            static double RangeMid(Range<double> range) => (range.Min + range.Max) / 2.0;

            static void Add<T>(Dictionary<double, List<T>> results, double delay, T result)
            {
                if (!results.TryGetValue(delay, out List<T>? values))
                {
                    values = [];
                    results[delay] = values;
                }

                values.Add(result);
            }

            // Orders the groups of a bin by material. The grouping query returns a Dictionary, whose
            // enumeration order is not a contract, and the groups are listed as table rows in the
            // Details drill-down, so an order that does not depend on how the hits happened to arrive
            // is imposed here rather than client side.
            static int Compare(ElectricalProperties electricalProperties_1, ElectricalProperties electricalProperties_2)
            {
                int result = string.CompareOrdinal(electricalProperties_1.Name, electricalProperties_2.Name);
                if (result != 0)
                {
                    return result;
                }

                result = electricalProperties_1.A.CompareTo(electricalProperties_2.A);
                if (result != 0)
                {
                    return result;
                }

                result = electricalProperties_1.B.CompareTo(electricalProperties_2.B);
                if (result != 0)
                {
                    return result;
                }

                result = electricalProperties_1.C.CompareTo(electricalProperties_2.C);
                if (result != 0)
                {
                    return result;
                }

                return electricalProperties_1.D.CompareTo(electricalProperties_2.D);
            }

            // Payload wide identity of a set of electrical properties. The client merges the half
            // degree bins of the payload into whole degree buckets and has to merge their groups with
            // them, which needs an identity that survives the bin boundary; the properties themselves
            // travel per group and per bin, and carry no frequency range, so they cannot serve as one.
            // ElectricalProperties has value equality over its name, coefficients and frequency range,
            // so equal instances collapse onto a single key.
            Dictionary<ElectricalProperties, int> electricalPropertiesKeys = [];

            int ElectricalPropertiesKey(ElectricalProperties electricalProperties)
            {
                if (!electricalPropertiesKeys.TryGetValue(electricalProperties, out int result))
                {
                    result = electricalPropertiesKeys.Count;
                    electricalPropertiesKeys[electricalProperties] = result;
                }

                return result;
            }

            // Display forms of the hit references, resolved once per distinct reference: parsing a
            // reference chain walks the whole nested string, and the hits of a bin overwhelmingly
            // point at the same handful of scattering objects.
            Dictionary<string, string?> displayReferences = [];

            string? DisplayReference(string? reference)
            {
                if (string.IsNullOrWhiteSpace(reference))
                {
                    return null;
                }

                if (!displayReferences.TryGetValue(reference, out string? result))
                {
                    result = Query.DisplayReference(reference);
                    displayReferences[reference] = result;
                }

                return result;
            }

            // All available delays, ascending (the delay slider order in the General panel).
            SortedSet<double> delays = [];

            // Result fragments keyed by delay.
            Dictionary<double, List<Classes.EllipsoidResult>> ellipsoidResults = [];
            Dictionary<double, List<Classes.ScatteringPolylineResult>> scatteringPolylineResults = [];
            Dictionary<double, List<Classes.VectorGroupResult>> vectorGroupResults = [];
            Dictionary<double, List<Classes.AngularPowerDistributionResult>> angularPowerDistributionResults = [];

            // References of the scattering objects actually hit. Only these are described at the top
            // level: a district holds thousands of scattering objects but the scattering hits touch a
            // handful of them, and a reference string is long enough that sending the whole lookup
            // would dominate the payload.
            HashSet<string> scatteringHitReferences = [];

            IEnumerable<ScatteringProfile>? scatteringProfiles = geometricalPropagationModel.GetScatteringProfiles<ScatteringProfile>();
            if (scatteringProfiles is not null)
            {
                foreach (ScatteringProfile scatteringProfile in scatteringProfiles)
                {
                    if (scatteringProfile?.Scatterings is not IEnumerable<Scattering> scatterings)
                    {
                        continue;
                    }

                    Point3D? location_1 = scatteringProfile.Location_1;
                    Point3D? location_2 = scatteringProfile.Location_2;
                    if (location_1 is null || location_2 is null)
                    {
                        continue;
                    }

                    Classes.Point3DResult? point3DResult_Location_1 = location_1.Point3DResult();
                    Classes.Point3DResult? point3DResult_Location_2 = location_2.Point3DResult();

                    foreach (Scattering scattering in scatterings)
                    {
                        // The delay for a given scattering is the same for all points in its
                        // scattering point groups.
                        double delay = scattering.Delay;

                        delays.Add(delay);

                        // The propagation ellipsoid for the given delay, meshed and cut by the
                        // horizontal plane at the lowest scattering object elevation. Called
                        // statically because this class shadows DiGi.Communication.Create for
                        // unqualified use inside the DiGi.Communication.WebAPI namespace.
                        Ellipsoid? ellipsoid = DiGi.Communication.Create.Ellipsoid(location_1, location_2, delay);
                        if (ellipsoid.EllipsoidResult(minElevation) is Classes.EllipsoidResult ellipsoidResult)
                        {
                            Add(ellipsoidResults, delay, ellipsoidResult);
                        }

                        if (scattering.ScatteringPointGroups is not IEnumerable<ScatteringPointGroup> scatteringPointGroups)
                        {
                            continue;
                        }

                        foreach (ScatteringPointGroup scatteringPointGroup in scatteringPointGroups)
                        {
                            if (scatteringPointGroup?.Points is not List<Point3D> point3Ds || point3Ds.Count == 0)
                            {
                                continue;
                            }

                            // One polyline per ScatteringPointGroup (reference identifies the
                            // component the group was created for); the profile locations enable
                            // the auxiliary polylines (location_1 -> point -> location_2) shown
                            // when the polyline is selected in the 3D view.
                            Add(scatteringPolylineResults, delay, new Classes.ScatteringPolylineResult(scatteringPointGroup.Reference, point3DResult_Location_1, point3DResult_Location_2, point3Ds.Point3DResults()));
                        }
                    }
                }
            }

            IEnumerable<AngularPowerDistributionProfile>? angularPowerDistributionProfiles = geometricalPropagationModel.GetAngularPowerDistributionProfiles<AngularPowerDistributionProfile>();
            if (angularPowerDistributionProfiles is not null)
            {
                foreach (AngularPowerDistributionProfile angularPowerDistributionProfile in angularPowerDistributionProfiles)
                {
                    if (angularPowerDistributionProfile.Location is not Point3D location || angularPowerDistributionProfile.AngularPowerDistributions is not IEnumerable<AngularPowerDistribution> angularPowerDistributions)
                    {
                        continue;
                    }

                    Classes.Point3DResult? point3DResult_Location = location.Point3DResult();

                    foreach (AngularPowerDistribution angularPowerDistribution in angularPowerDistributions)
                    {
                        // The delay for an angular power distribution is the same for all vectors
                        // in the distribution.
                        double delay = angularPowerDistribution.Delay;

                        delays.Add(delay);

                        // The scattering hits behind the vectors, kept in their azimuth/elevation
                        // bins so the Details form of the Results panel can render them as a matrix
                        // and drill down into a single bin. Built before the Vectors guard below so
                        // a distribution without renderable vectors still contributes its matrix.
                        // Only populated bins are described, and only non-empty intersections are
                        // emitted: the two range lists are filtered independently, so their cross
                        // product is overwhelmingly empty.
                        // Within a bin the hits are grouped by the electrical properties of the
                        // scattering objects they point at, which is the middle step of the three step
                        // drill-down: the matrix cell counts the groups, the groups are listed with
                        // their materials, and one group opens its hits.
                        if (angularPowerDistribution.GetAzimuthRanges(true) is IReadOnlyList<Range<double>> azimuthRanges && azimuthRanges.Count != 0
                            && angularPowerDistribution.GetElevationRanges(true) is IReadOnlyList<Range<double>> elevationRanges && elevationRanges.Count != 0)
                        {
                            List<Classes.ScatteringHitCellResult> scatteringHitCellResults = [];
                            for (int i = 0; i < azimuthRanges.Count; i++)
                            {
                                double azimuth = RangeMid(azimuthRanges[i]);
                                for (int j = 0; j < elevationRanges.Count; j++)
                                {
                                    double elevation = RangeMid(elevationRanges[j]);

                                    // Emptiness is established before grouping so the empty majority of
                                    // the cross product is skipped without any scattering object lookup.
                                    // This is the same collection lookup the grouping query runs
                                    // internally, so it only costs a repeated lookup on populated bins.
                                    if (angularPowerDistribution.GetScatteringHits(azimuth, elevation) is not IReadOnlyList<IScatteringHit> scatteringHits || scatteringHits.Count == 0)
                                    {
                                        continue;
                                    }

                                    // Called fully qualified because this class shadows
                                    // DiGi.Communication.Query for unqualified use inside the
                                    // DiGi.Communication.WebAPI namespace.
                                    // Two behaviours of the query the payload inherits: a hit whose
                                    // reference resolves to no scattering object, or to one carrying no
                                    // electrical properties, is dropped rather than grouped - every
                                    // scattering object converted from a building model carries
                                    // Concrete, so that is not expected here; and a hit whose reference
                                    // resolves to several scattering objects with differing properties
                                    // joins every matching group, so the group sizes can sum to more
                                    // than the hit count of the bin.
                                    if (DiGi.Communication.Query.ScatteringHitsByElectricalProperties<IScatteringHit>(geometricalPropagationModel, angularPowerDistribution, azimuth, elevation) is not Dictionary<ElectricalProperties, List<IScatteringHit>> scatteringHitsByElectricalProperties || scatteringHitsByElectricalProperties.Count == 0)
                                    {
                                        continue;
                                    }

                                    List<ElectricalProperties> electricalProperties_Sorted = [.. scatteringHitsByElectricalProperties.Keys];
                                    electricalProperties_Sorted.Sort(Compare);

                                    List<Classes.ScatteringHitGroupResult> scatteringHitGroupResults = [];
                                    foreach (ElectricalProperties electricalProperties in electricalProperties_Sorted)
                                    {
                                        List<Classes.ScatteringHitResult> scatteringHitResults = [];
                                        foreach (IScatteringHit scatteringHit in scatteringHitsByElectricalProperties[electricalProperties])
                                        {
                                            if (scatteringHit.ScatteringHitResult(DisplayReference(scatteringHit.Reference)) is not Classes.ScatteringHitResult scatteringHitResult)
                                            {
                                                continue;
                                            }

                                            if (scatteringHitResult.Reference is string reference && !string.IsNullOrWhiteSpace(reference))
                                            {
                                                scatteringHitReferences.Add(reference);
                                            }

                                            scatteringHitResults.Add(scatteringHitResult);
                                        }

                                        if (scatteringHitResults.Count == 0)
                                        {
                                            continue;
                                        }

                                        scatteringHitGroupResults.Add(new(ElectricalPropertiesKey(electricalProperties), electricalProperties.ElectricalPropertiesResult(), scatteringHitResults));
                                    }

                                    if (scatteringHitGroupResults.Count == 0)
                                    {
                                        continue;
                                    }

                                    scatteringHitCellResults.Add(new(i, j, scatteringHitGroupResults));
                                }
                            }

                            if (scatteringHitCellResults.Count != 0)
                            {
                                Add(angularPowerDistributionResults, delay, new Classes.AngularPowerDistributionResult(point3DResult_Location, azimuthRanges.RangeResults(), elevationRanges.RangeResults(), scatteringHitCellResults));
                            }
                        }

                        // The vectors visualized at the location; their length carries the power,
                        // so they are sent unnormalized and scaled client side only.
                        if (angularPowerDistribution.Vectors is not IEnumerable<Vector3D> vector3Ds || !vector3Ds.Any())
                        {
                            continue;
                        }

                        Add(vectorGroupResults, delay, new Classes.VectorGroupResult(point3DResult_Location, vector3Ds.Vector3DResults()));
                    }
                }
            }

            // Electrical properties of the scattering objects the hits above point at, keyed by that
            // reference. Resolved in one bulk lookup rather than per hit, and restricted to the hit
            // references so an unhit district does not travel to the client.
            Dictionary<string, Classes.ElectricalPropertiesResult> electricalPropertiesResults = [];
            if (scatteringHitReferences.Count != 0 && DiGi.Communication.Query.ElectricalPropertiesByReference(geometricalPropagationModel) is Dictionary<string, ElectricalProperties> electricalPropertiesByReference)
            {
                foreach (string reference in scatteringHitReferences)
                {
                    if (!electricalPropertiesByReference.TryGetValue(reference, out ElectricalProperties? electricalProperties))
                    {
                        continue;
                    }

                    if (electricalProperties.ElectricalPropertiesResult() is Classes.ElectricalPropertiesResult electricalPropertiesResult)
                    {
                        electricalPropertiesResults[reference] = electricalPropertiesResult;
                    }
                }
            }

            List<Classes.DelayResult> delayResults = [];
            foreach (double delay in delays)
            {
                delayResults.Add(new(delay, ellipsoidResults.GetValueOrDefault(delay), scatteringPolylineResults.GetValueOrDefault(delay), vectorGroupResults.GetValueOrDefault(delay), angularPowerDistributionResults.GetValueOrDefault(delay)));
            }

            if (delayResults.Count == 0)
            {
                return null;
            }

            // The delays list (ascending, one entry per delayResults entry) discriminates this V1
            // payload from the V2 one in communication-tools.js and feeds the delay slider.
            return new(transmitter.Distance(receiver), transmitter.Point3DResult(), receiver.Point3DResult(), [.. delays], electricalPropertiesResults, delayResults);
        }
    }
}
