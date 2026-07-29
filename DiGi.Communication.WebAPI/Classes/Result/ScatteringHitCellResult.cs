using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents a populated azimuth and elevation bin of an angular power distribution of the propagation calculation result.
    /// <para><see cref="AzimuthIndex"/> and <see cref="ElevationIndex"/> address <see cref="AngularPowerDistributionResult.AzimuthRanges"/> and <see cref="AngularPowerDistributionResult.ElevationRanges"/>. Only non-empty intersections are described: the two range lists are filtered independently, so their cross product is overwhelmingly empty.</para>
    /// </summary>
    public class ScatteringHitCellResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringHitCellResult"/> class.
        /// </summary>
        /// <param name="azimuthIndex">The index of the azimuth bin.</param>
        /// <param name="elevationIndex">The index of the elevation bin.</param>
        /// <param name="hits">The scattering hits falling into the bin.</param>
        public ScatteringHitCellResult(int azimuthIndex, int elevationIndex, List<ScatteringHitResult>? hits)
        {
            AzimuthIndex = azimuthIndex;
            ElevationIndex = elevationIndex;
            Hits = hits ?? [];
        }

        /// <summary> Gets the index of the azimuth bin. </summary>
        [JsonPropertyName("azimuthIndex")]
        public int AzimuthIndex { get; }

        /// <summary> Gets the index of the elevation bin. </summary>
        [JsonPropertyName("elevationIndex")]
        public int ElevationIndex { get; }

        /// <summary> Gets the scattering hits falling into the bin. </summary>
        [JsonPropertyName("hits")]
        public List<ScatteringHitResult> Hits { get; }
    }
}
