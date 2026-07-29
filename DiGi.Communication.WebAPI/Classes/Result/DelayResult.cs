using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents the part of the propagation calculation result belonging to a single delay.
    /// <para>All geometry is expressed in world coordinates. The consuming application renders one delay at a time, so every collection is scoped to <see cref="Delay"/> and is empty rather than null when the delay contributes nothing of that kind.</para>
    /// </summary>
    public class DelayResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DelayResult"/> class.
        /// </summary>
        /// <param name="delay">The delay the result belongs to.</param>
        /// <param name="ellipsoids">The propagation ellipsoids of the delay.</param>
        /// <param name="polylines">The scattering polylines of the delay, one per scattering point group.</param>
        /// <param name="vectorGroups">The angular power distribution vectors of the delay, grouped by location.</param>
        /// <param name="angularDistributions">The angular power distributions of the delay.</param>
        public DelayResult(double delay, List<EllipsoidResult>? ellipsoids, List<ScatteringPolylineResult>? polylines, List<VectorGroupResult>? vectorGroups, List<AngularPowerDistributionResult>? angularDistributions)
        {
            Delay = delay;
            Ellipsoids = ellipsoids ?? [];
            Polylines = polylines ?? [];
            VectorGroups = vectorGroups ?? [];
            AngularDistributions = angularDistributions ?? [];
        }

        /// <summary> Gets the angular power distributions of the delay. </summary>
        [JsonPropertyName("angularDistributions")]
        public List<AngularPowerDistributionResult> AngularDistributions { get; }

        /// <summary> Gets the delay the result belongs to. </summary>
        [JsonPropertyName("delay")]
        public double Delay { get; }

        /// <summary> Gets the propagation ellipsoids of the delay. </summary>
        [JsonPropertyName("ellipsoids")]
        public List<EllipsoidResult> Ellipsoids { get; }

        /// <summary> Gets the scattering polylines of the delay, one per scattering point group. </summary>
        [JsonPropertyName("polylines")]
        public List<ScatteringPolylineResult> Polylines { get; }

        /// <summary> Gets the angular power distribution vectors of the delay, grouped by location. </summary>
        [JsonPropertyName("vectorGroups")]
        public List<VectorGroupResult> VectorGroups { get; }
    }
}
