using DiGi.Communication.Classes;

namespace DiGi.Communication.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates an <see cref="Classes.ElectricalPropertiesResult"/> for the propagation calculation result from the specified <see cref="ElectricalProperties"/>.
        /// </summary>
        /// <param name="electricalProperties">The electrical properties of a scattering object. This value can be null.</param>
        /// <returns>An <see cref="Classes.ElectricalPropertiesResult"/> holding the name and the frequency dependency coefficients of the material, or null if the electrical properties are null.</returns>
        public static Classes.ElectricalPropertiesResult? ElectricalPropertiesResult(this ElectricalProperties? electricalProperties)
        {
            if (electricalProperties is null)
            {
                return null;
            }

            return new(electricalProperties.Name, electricalProperties.A, electricalProperties.B, electricalProperties.C, electricalProperties.D);
        }
    }
}
