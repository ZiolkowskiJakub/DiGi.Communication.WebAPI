using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents a propagation ellipsoid of the propagation calculation result in world coordinates.
    /// <para><see cref="Mesh"/> is the triangulated ellipsoid cut by the horizontal plane at the lowest scattering object elevation, so only the part above the ground plane is described. It is null when no renderable geometry could be produced, in which case the consuming application falls back to the analytic parameters (<see cref="Center"/>, <see cref="Axis"/>, <see cref="SemiMajorAxis"/> and <see cref="SemiMinorAxis"/>).</para>
    /// </summary>
    public class EllipsoidResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EllipsoidResult"/> class.
        /// </summary>
        /// <param name="center">The center of the ellipsoid.</param>
        /// <param name="axis">The direction of the major axis of the ellipsoid.</param>
        /// <param name="semiMajorAxis">The length of the semi major axis of the ellipsoid.</param>
        /// <param name="semiMinorAxis">The length of the semi minor axis of the ellipsoid.</param>
        /// <param name="mesh">The triangulated geometry of the ellipsoid above the ground plane, or null when no renderable geometry could be produced.</param>
        public EllipsoidResult(Point3DResult? center, Vector3DResult? axis, double semiMajorAxis, double semiMinorAxis, Mesh3DResult? mesh)
        {
            Center = center;
            Axis = axis;
            SemiMajorAxis = semiMajorAxis;
            SemiMinorAxis = semiMinorAxis;
            Mesh = mesh;
        }

        /// <summary> Gets the direction of the major axis of the ellipsoid. </summary>
        [JsonPropertyName("axis")]
        public Vector3DResult? Axis { get; }

        /// <summary> Gets the center of the ellipsoid. </summary>
        [JsonPropertyName("center")]
        public Point3DResult? Center { get; }

        /// <summary> Gets the triangulated geometry of the ellipsoid above the ground plane, or null when no renderable geometry could be produced. </summary>
        [JsonPropertyName("mesh")]
        public Mesh3DResult? Mesh { get; }

        /// <summary> Gets the length of the semi major axis of the ellipsoid. </summary>
        [JsonPropertyName("semiMajorAxis")]
        public double SemiMajorAxis { get; }

        /// <summary> Gets the length of the semi minor axis of the ellipsoid. </summary>
        [JsonPropertyName("semiMinorAxis")]
        public double SemiMinorAxis { get; }
    }
}
