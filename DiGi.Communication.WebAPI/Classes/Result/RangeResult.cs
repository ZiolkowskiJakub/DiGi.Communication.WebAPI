using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents an angular bin of the propagation calculation result.
    /// <para>The bounds are expressed in radians, as everything else in this payload; the consuming application converts them for display.</para>
    /// </summary>
    public class RangeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeResult"/> class.
        /// </summary>
        /// <param name="min">The lower bound of the bin.</param>
        /// <param name="max">The upper bound of the bin.</param>
        public RangeResult(double min, double max)
        {
            Min = min;
            Max = max;
        }

        /// <summary> Gets the upper bound of the bin. </summary>
        [JsonPropertyName("max")]
        public double Max { get; }

        /// <summary> Gets the lower bound of the bin. </summary>
        [JsonPropertyName("min")]
        public double Min { get; }
    }
}
