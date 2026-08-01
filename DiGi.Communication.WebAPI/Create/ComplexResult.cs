using System.Numerics;

namespace DiGi.Communication.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.ComplexResult"/> for the propagation calculation result from the specified <see cref="Complex"/>.
        /// </summary>
        /// <param name="complex">The complex number. This value can be null.</param>
        /// <returns>A <see cref="Classes.ComplexResult"/> holding the components of the complex number, or null if the complex number is null or does not carry finite components.</returns>
        public static Classes.ComplexResult? ComplexResult(this Complex? complex)
        {
            // A component that could not be derived is NaN or infinity, neither of which is valid JSON:
            // System.Text.Json rejects both with the default number handling, so such a value travels as null.
            if (complex is not Complex value || !DiGi.Core.Query.IsValid(value))
            {
                return null;
            }

            return new(value.Real, value.Imaginary);
        }
    }
}
