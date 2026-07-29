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
                        if (angularPowerDistribution.GetAzimuthRanges(true) is IReadOnlyList<Range<double>> azimuthRanges && azimuthRanges.Count != 0
                            && angularPowerDistribution.GetElevationRanges(true) is IReadOnlyList<Range<double>> elevationRanges && elevationRanges.Count != 0)
                        {
                            List<Classes.ScatteringHitCellResult> scatteringHitCellResults = [];
                            for (int i = 0; i < azimuthRanges.Count; i++)
                            {
                                double azimuth = RangeMid(azimuthRanges[i]);
                                for (int j = 0; j < elevationRanges.Count; j++)
                                {
                                    if (angularPowerDistribution.GetScatteringHits(azimuth, RangeMid(elevationRanges[j])) is not IReadOnlyList<IScatteringHit> scatteringHits || scatteringHits.Count == 0)
                                    {
                                        continue;
                                    }

                                    List<Classes.ScatteringHitResult> scatteringHitResults = [];
                                    foreach (IScatteringHit scatteringHit in scatteringHits)
                                    {
                                        if (scatteringHit.ScatteringHitResult() is not Classes.ScatteringHitResult scatteringHitResult)
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

                                    scatteringHitCellResults.Add(new(i, j, scatteringHitResults));
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
