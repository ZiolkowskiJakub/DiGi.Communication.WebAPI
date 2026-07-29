using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents the electrical properties of a scattering object the propagation calculation result refers to.
    /// <para>The coefficients describe the frequency dependency of the material: the relative permittivity is derived from <see cref="A"/> and <see cref="B"/>, the conductivity from <see cref="C"/> and <see cref="D"/>.</para>
    /// </summary>
    public class ElectricalPropertiesResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricalPropertiesResult"/> class.
        /// </summary>
        /// <param name="name">The name of the material.</param>
        /// <param name="a">The relative permittivity coefficient.</param>
        /// <param name="b">The relative permittivity exponent.</param>
        /// <param name="c">The conductivity coefficient.</param>
        /// <param name="d">The conductivity exponent.</param>
        public ElectricalPropertiesResult(string? name, double a, double b, double c, double d)
        {
            Name = name;
            A = a;
            B = b;
            C = c;
            D = d;
        }

        /// <summary> Gets the relative permittivity coefficient. </summary>
        [JsonPropertyName("a")]
        public double A { get; }

        /// <summary> Gets the relative permittivity exponent. </summary>
        [JsonPropertyName("b")]
        public double B { get; }

        /// <summary> Gets the conductivity coefficient. </summary>
        [JsonPropertyName("c")]
        public double C { get; }

        /// <summary> Gets the conductivity exponent. </summary>
        [JsonPropertyName("d")]
        public double D { get; }

        /// <summary> Gets the name of the material. </summary>
        [JsonPropertyName("name")]
        public string? Name { get; }
    }
}
