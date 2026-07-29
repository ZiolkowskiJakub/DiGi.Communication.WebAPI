using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents a direction of the propagation calculation result in world coordinates.
    /// <para>The vectors are sent unnormalized: their length carries the power, so the consuming application scales them for display instead of recovering the magnitude.</para>
    /// </summary>
    public class Vector3DResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3DResult"/> class.
        /// </summary>
        /// <param name="x">The X component of the direction.</param>
        /// <param name="y">The Y component of the direction.</param>
        /// <param name="z">The Z component of the direction.</param>
        public Vector3DResult(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary> Gets the X component of the direction. </summary>
        [JsonPropertyName("x")]
        public double X { get; }

        /// <summary> Gets the Y component of the direction. </summary>
        [JsonPropertyName("y")]
        public double Y { get; }

        /// <summary> Gets the Z component of the direction. </summary>
        [JsonPropertyName("z")]
        public double Z { get; }
    }
}
