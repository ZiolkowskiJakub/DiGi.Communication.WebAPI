using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents a scattering polyline of the propagation calculation result in world coordinates, one per scattering point group.
    /// <para><see cref="Reference"/> identifies the component the group was created for. <see cref="Location1"/> and <see cref="Location2"/> are the locations of the scattering profile the group belongs to; they enable the auxiliary polylines (location 1 to point to location 2) the consuming application draws when the polyline is selected.</para>
    /// </summary>
    public class ScatteringPolylineResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringPolylineResult"/> class.
        /// </summary>
        /// <param name="reference">The reference of the component the scattering point group was created for.</param>
        /// <param name="location1">The first location of the scattering profile.</param>
        /// <param name="location2">The second location of the scattering profile.</param>
        /// <param name="points">The points of the polyline.</param>
        public ScatteringPolylineResult(string? reference, Point3DResult? location1, Point3DResult? location2, List<Point3DResult>? points)
        {
            Reference = reference;
            Location1 = location1;
            Location2 = location2;
            Points = points ?? [];
        }

        /// <summary> Gets the first location of the scattering profile. </summary>
        [JsonPropertyName("location1")]
        public Point3DResult? Location1 { get; }

        /// <summary> Gets the second location of the scattering profile. </summary>
        [JsonPropertyName("location2")]
        public Point3DResult? Location2 { get; }

        /// <summary> Gets the points of the polyline. </summary>
        [JsonPropertyName("points")]
        public List<Point3DResult> Points { get; }

        /// <summary> Gets the reference of the component the scattering point group was created for. </summary>
        [JsonPropertyName("reference")]
        public string? Reference { get; }
    }
}
