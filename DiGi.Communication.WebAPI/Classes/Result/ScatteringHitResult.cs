using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents a single scattering hit of the propagation calculation result.
    /// <para>A scattering hit carries no location: the direction is the per hit quantity the azimuth and elevation binning is derived from, and it is unnormalized (its length carries the power). The components are therefore held directly on this type rather than in a nested direction object.</para>
    /// <para><see cref="Reference"/> identifies the scattering object that was hit; its electrical properties are described by the <see cref="ScatteringHitGroupResult"/> the hit belongs to and once at the top level of <see cref="GeometricalPropagationResult.ScatteringObjects"/>, rather than repeated on every hit.</para>
    /// </summary>
    public class ScatteringHitResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringHitResult"/> class.
        /// </summary>
        /// <param name="x">The X component of the hit direction.</param>
        /// <param name="y">The Y component of the hit direction.</param>
        /// <param name="z">The Z component of the hit direction.</param>
        /// <param name="reference">The reference of the scattering object that was hit.</param>
        /// <param name="displayReference">The display form of the reference of the scattering object that was hit.</param>
        public ScatteringHitResult(double x, double y, double z, string? reference, string? displayReference)
        {
            X = x;
            Y = y;
            Z = z;
            Reference = reference;
            DisplayReference = displayReference;
        }

        /// <summary>
        /// Gets the display form of <see cref="Reference"/>: the unique identifier of the last step of the reference chain.
        /// <para>A reference of a scattering object runs to a few hundred characters, which is unreadable in a table cell, so its last step is sent alongside it for display; the consuming application shows this value and keeps the full <see cref="Reference"/> as the hover text.</para>
        /// <para>Null when the reference is null, empty, or not a parseable reference chain, in which case the consuming application falls back to the full <see cref="Reference"/>.</para>
        /// </summary>
        [JsonPropertyName("displayReference")]
        public string? DisplayReference { get; }

        /// <summary> Gets the reference of the scattering object that was hit. </summary>
        [JsonPropertyName("reference")]
        public string? Reference { get; }

        /// <summary> Gets the X component of the hit direction. </summary>
        [JsonPropertyName("x")]
        public double X { get; }

        /// <summary> Gets the Y component of the hit direction. </summary>
        [JsonPropertyName("y")]
        public double Y { get; }

        /// <summary> Gets the Z component of the hit direction. </summary>
        [JsonPropertyName("z")]
        public double Z { get; }
    }
}
