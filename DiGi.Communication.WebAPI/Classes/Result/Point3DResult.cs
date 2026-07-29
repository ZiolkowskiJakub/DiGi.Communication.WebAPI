using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents a location of the propagation calculation result in world coordinates.
    /// </summary>
    public class Point3DResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point3DResult"/> class.
        /// </summary>
        /// <param name="x">The X coordinate of the location.</param>
        /// <param name="y">The Y coordinate of the location.</param>
        /// <param name="z">The Z coordinate of the location.</param>
        public Point3DResult(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary> Gets the X coordinate of the location. </summary>
        [JsonPropertyName("x")]
        public double X { get; }

        /// <summary> Gets the Y coordinate of the location. </summary>
        [JsonPropertyName("y")]
        public double Y { get; }

        /// <summary> Gets the Z coordinate of the location. </summary>
        [JsonPropertyName("z")]
        public double Z { get; }
    }
}
