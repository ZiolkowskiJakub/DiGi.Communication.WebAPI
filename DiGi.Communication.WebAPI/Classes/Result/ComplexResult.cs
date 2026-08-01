using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents a complex number of the propagation calculation result.
    /// <para>A complex number has no numeric JSON form, so it travels as its two components. This is the computable form: a consuming application that has to aggregate complex values (averaging the reflection coefficients of a group of hits, for example) works from these numbers rather than from a rendered string.</para>
    /// </summary>
    public class ComplexResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexResult"/> class.
        /// </summary>
        /// <param name="real">The real component of the complex number.</param>
        /// <param name="imaginary">The imaginary component of the complex number.</param>
        public ComplexResult(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        /// <summary> Gets the imaginary component of the complex number. </summary>
        [JsonPropertyName("imaginary")]
        public double Imaginary { get; }

        /// <summary> Gets the real component of the complex number. </summary>
        [JsonPropertyName("real")]
        public double Real { get; }
    }
}
