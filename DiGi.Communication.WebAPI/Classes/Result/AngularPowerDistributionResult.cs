using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents an angular power distribution of the propagation calculation result at a single location.
    /// <para>The scattering hits behind the vectors are kept in their azimuth and elevation bins so the consuming application can render them as a matrix and drill down into a single bin. Only populated bins are described.</para>
    /// </summary>
    public class AngularPowerDistributionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AngularPowerDistributionResult"/> class.
        /// </summary>
        /// <param name="location">The location of the angular power distribution.</param>
        /// <param name="azimuthRanges">The populated azimuth bins.</param>
        /// <param name="elevationRanges">The populated elevation bins.</param>
        /// <param name="cells">The populated azimuth and elevation bin intersections holding the scattering hits.</param>
        public AngularPowerDistributionResult(Point3DResult? location, List<RangeResult>? azimuthRanges, List<RangeResult>? elevationRanges, List<ScatteringHitCellResult>? cells)
        {
            Location = location;
            AzimuthRanges = azimuthRanges ?? [];
            ElevationRanges = elevationRanges ?? [];
            Cells = cells ?? [];
        }

        /// <summary> Gets the populated azimuth bins. </summary>
        [JsonPropertyName("azimuthRanges")]
        public List<RangeResult> AzimuthRanges { get; }

        /// <summary> Gets the populated azimuth and elevation bin intersections holding the scattering hits. </summary>
        [JsonPropertyName("cells")]
        public List<ScatteringHitCellResult> Cells { get; }

        /// <summary> Gets the populated elevation bins. </summary>
        [JsonPropertyName("elevationRanges")]
        public List<RangeResult> ElevationRanges { get; }

        /// <summary> Gets the location of the angular power distribution. </summary>
        [JsonPropertyName("location")]
        public Point3DResult? Location { get; }
    }
}
