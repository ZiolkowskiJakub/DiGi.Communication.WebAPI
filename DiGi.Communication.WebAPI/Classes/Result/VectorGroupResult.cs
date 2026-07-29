using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents the angular power distribution vectors of the propagation calculation result visualized at a single location.
    /// <para>The vectors are sent unnormalized: their length carries the power, so the consuming application scales them for display.</para>
    /// </summary>
    public class VectorGroupResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VectorGroupResult"/> class.
        /// </summary>
        /// <param name="location">The location the vectors are visualized at.</param>
        /// <param name="vectors">The vectors visualized at the location.</param>
        public VectorGroupResult(Point3DResult? location, List<Vector3DResult>? vectors)
        {
            Location = location;
            Vectors = vectors ?? [];
        }

        /// <summary> Gets the location the vectors are visualized at. </summary>
        [JsonPropertyName("location")]
        public Point3DResult? Location { get; }

        /// <summary> Gets the vectors visualized at the location. </summary>
        [JsonPropertyName("vectors")]
        public List<Vector3DResult> Vectors { get; }
    }
}
