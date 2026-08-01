using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents a single scattering hit of the propagation calculation result.
    /// <para>Everything a hit describes is read off the hit itself: it carries its own location, its own electrical properties and the derived material and geometry values, so a consuming application needs no lookup to render a row.</para>
    /// <para>The angles are sent in radians like every other angle of this payload, and the consuming application converts them for display. A value that could not be derived (missing electrical properties, missing antenna location) is sent as null rather than as NaN: NaN is not valid JSON and the serializer rejects it.</para>
    /// <para><see cref="VerticalPolarizationReflection"/> is the one value that travels as a string rather than as a number: it is a complex number, which has no numeric JSON form, so it is rendered by <see cref="DiGi.Core.Convert.ToSystem_String(System.Numerics.Complex, double, double)"/>, the canonical rendering of a complex number in this project.</para>
    /// <para><see cref="VectorReceiver"/>, <see cref="VectorTransmitter"/> and <see cref="Normal"/> are unit vectors, unlike the angular power distribution vectors of <see cref="VectorGroupResult"/>, whose length carries the power.</para>
    /// </summary>
    public class ScatteringHitResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringHitResult"/> class.
        /// </summary>
        /// <param name="location">The location of the hit point in world coordinates.</param>
        /// <param name="reference">The reference of the scattering object that was hit.</param>
        /// <param name="displayReference">The display form of the reference of the scattering object that was hit.</param>
        /// <param name="electricalProperties">The electrical properties of the scattering object that was hit.</param>
        /// <param name="conductivity">The material conductivity [S/m] at the operating frequency.</param>
        /// <param name="relativePermittivity">The material relative permittivity at the operating frequency.</param>
        /// <param name="reflectionAngle">The reflection angle [rad] relative to the surface normal.</param>
        /// <param name="grazingAngle">The grazing angle [rad] relative to the surface tangent plane.</param>
        /// <param name="vectorReceiver">The unit direction vector from the hit point towards the receiver.</param>
        /// <param name="vectorTransmitter">The unit direction vector from the transmitter towards the hit point.</param>
        /// <param name="normal">The unit surface normal vector at the hit point.</param>
        /// <param name="verticalPolarizationReflection">The complex reflection coefficient for vertical polarization, already rendered as a string.</param>
        public ScatteringHitResult(
            Point3DResult? location,
            string? reference,
            string? displayReference,
            ElectricalPropertiesResult? electricalProperties,
            double? conductivity,
            double? relativePermittivity,
            double? reflectionAngle,
            double? grazingAngle,
            Vector3DResult? vectorReceiver,
            Vector3DResult? vectorTransmitter,
            Vector3DResult? normal,
            string? verticalPolarizationReflection)
        {
            Location = location;
            Reference = reference;
            DisplayReference = displayReference;
            ElectricalProperties = electricalProperties;
            Conductivity = conductivity;
            RelativePermittivity = relativePermittivity;
            ReflectionAngle = reflectionAngle;
            GrazingAngle = grazingAngle;
            VectorReceiver = vectorReceiver;
            VectorTransmitter = vectorTransmitter;
            Normal = normal;
            VerticalPolarizationReflection = verticalPolarizationReflection;
        }

        /// <summary> Gets the material conductivity [S/m] at the operating frequency, or null if it could not be derived. </summary>
        [JsonPropertyName("conductivity")]
        public double? Conductivity { get; }

        /// <summary>
        /// Gets the display form of <see cref="Reference"/>: the unique identifier of the last step of the reference chain.
        /// <para>A reference of a scattering object runs to a few hundred characters, which is unreadable in a table cell, so its last step is sent alongside it for display; the consuming application shows this value and keeps the full <see cref="Reference"/> as the hover text.</para>
        /// <para>Null when the reference is null, empty, or not a parseable reference chain, in which case the consuming application falls back to the full <see cref="Reference"/>.</para>
        /// </summary>
        [JsonPropertyName("displayReference")]
        public string? DisplayReference { get; }

        /// <summary> Gets the electrical properties of the scattering object that was hit, or null if it carries none. </summary>
        [JsonPropertyName("electricalProperties")]
        public ElectricalPropertiesResult? ElectricalProperties { get; }

        /// <summary> Gets the grazing angle [rad] relative to the surface tangent plane, or null if it could not be derived. </summary>
        [JsonPropertyName("grazingAngle")]
        public double? GrazingAngle { get; }

        /// <summary> Gets the location of the hit point in world coordinates, or null if the hit carries none. </summary>
        [JsonPropertyName("location")]
        public Point3DResult? Location { get; }

        /// <summary> Gets the unit surface normal vector at the hit point, or null if it could not be derived. </summary>
        [JsonPropertyName("normal")]
        public Vector3DResult? Normal { get; }

        /// <summary> Gets the reference of the scattering object that was hit. </summary>
        [JsonPropertyName("reference")]
        public string? Reference { get; }

        /// <summary> Gets the reflection angle [rad] relative to the surface normal, or null if it could not be derived. </summary>
        [JsonPropertyName("reflectionAngle")]
        public double? ReflectionAngle { get; }

        /// <summary> Gets the material relative permittivity at the operating frequency, or null if it could not be derived. </summary>
        [JsonPropertyName("relativePermittivity")]
        public double? RelativePermittivity { get; }

        /// <summary> Gets the unit direction vector from the hit point towards the receiver, or null if it could not be derived. </summary>
        [JsonPropertyName("vectorReceiver")]
        public Vector3DResult? VectorReceiver { get; }

        /// <summary> Gets the unit direction vector from the transmitter towards the hit point, or null if it could not be derived. </summary>
        [JsonPropertyName("vectorTransmitter")]
        public Vector3DResult? VectorTransmitter { get; }

        /// <summary> Gets the complex reflection coefficient for vertical polarization, rendered as "{real}{+|-}j{imaginary}", or null if it could not be derived. </summary>
        [JsonPropertyName("verticalPolarizationReflection")]
        public string? VerticalPolarizationReflection { get; }
    }
}
