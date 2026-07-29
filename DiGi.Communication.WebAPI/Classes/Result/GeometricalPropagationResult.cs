using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents the result of a geometrical propagation calculation between a transmitter and a receiver antenna, grouped by delay (ascending).
    /// <para>Everything is expressed in world coordinates: the propagation ellipsoids, the scattering polylines (one per scattering point group) and the angular power distribution vectors. The consuming application drives a delay slider and renders <see cref="Results"/> one entry at a time.</para>
    /// <para>AI-NOTE (payload evolution): this is the V1 delay based payload, consumed by wwwroot/js/communication-tools.js in DiGi.GIS.WebAPI.UI (renderDelayResults, the Results and Details panels). The <see cref="Delays"/> array discriminates this V1 payload from the V2 one in that file. New fields are added as additional constructor parameters and properties on the type they belong to; the consumer tolerates unknown keys. Nulls are written rather than omitted, so a field that must stay invisible to older clients needs JsonIgnore with JsonIgnoreCondition.WhenWritingNull.</para>
    /// <para>AI-NOTE (serialization contract): these result types are deliberately NOT SerializableObject instances. A SerializableObject serializes as PascalCase property names plus a _type discriminator, whereas the 3D view reads the camelCase keys literally. The keys are therefore pinned by JsonPropertyName on every property, which makes them independent of the hosting application naming policy: the same instance serializes identically from this Web API and from the consuming application. Renaming a property is safe; changing an attribute value silently breaks the 3D view.</para>
    /// <para>AI-NOTE (ownership): this assembly currently exposes no endpoints; the consuming application runs the solvers itself and projects the outcome through Create.GeometricalPropagationResult. Once the propagation calculation is exposed over HTTP from this assembly, this type becomes that endpoint response and the consuming application proxies it unchanged.</para>
    /// </summary>
    public class GeometricalPropagationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometricalPropagationResult"/> class.
        /// </summary>
        /// <param name="distance">The distance between the transmitter and the receiver antenna.</param>
        /// <param name="transmitter">The location of the transmitter antenna.</param>
        /// <param name="receiver">The location of the receiver antenna.</param>
        /// <param name="delays">All available delays, ascending, one per entry of <paramref name="results"/>.</param>
        /// <param name="scatteringObjects">The electrical properties of the scattering objects that were hit, keyed by scattering object reference.</param>
        /// <param name="results">The calculation result grouped by delay, ascending.</param>
        public GeometricalPropagationResult(
            double distance,
            Point3DResult? transmitter,
            Point3DResult? receiver,
            List<double>? delays,
            Dictionary<string, ElectricalPropertiesResult>? scatteringObjects,
            List<DelayResult>? results)
        {
            Distance = distance;
            Transmitter = transmitter;
            Receiver = receiver;
            Delays = delays ?? [];
            ScatteringObjects = scatteringObjects ?? [];
            Results = results ?? [];
        }

        /// <summary> Gets all available delays, ascending, one per entry of <see cref="Results"/>. </summary>
        [JsonPropertyName("delays")]
        public List<double> Delays { get; }

        /// <summary> Gets the distance between the transmitter and the receiver antenna. </summary>
        [JsonPropertyName("distance")]
        public double Distance { get; }

        /// <summary> Gets the location of the receiver antenna. </summary>
        [JsonPropertyName("receiver")]
        public Point3DResult? Receiver { get; }

        /// <summary> Gets the calculation result grouped by delay, ascending. </summary>
        [JsonPropertyName("results")]
        public List<DelayResult> Results { get; }

        /// <summary>
        /// Gets the electrical properties of the scattering objects that were hit, keyed by scattering object reference.
        /// <para>Only the scattering objects the hits of <see cref="ScatteringHitCellResult.Hits"/> point at are described: an analyzed area holds thousands of scattering objects but the hits touch a handful of them, and a reference string is long enough that sending the whole lookup would dominate the payload.</para>
        /// </summary>
        [JsonPropertyName("scatteringObjects")]
        public Dictionary<string, ElectricalPropertiesResult> ScatteringObjects { get; }

        /// <summary> Gets the location of the transmitter antenna. </summary>
        [JsonPropertyName("transmitter")]
        public Point3DResult? Transmitter { get; }
    }
}
