using DiGi.Communication.Classes;
using DiGi.Communication.Enums;
using DiGi.Communication.Interfaces;
using System.Numerics;

namespace DiGi.Communication.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.ScatteringHitResult"/> for the propagation calculation result from the specified <see cref="IScatteringHit"/> and the display form of its reference.
        /// <para>The display form is supplied by the caller rather than derived here so it can be resolved once per distinct reference: <see cref="Query.DisplayReference(string)"/> parses the whole reference chain, which is wasted work when repeated for every hit pointing at the same scattering object.</para>
        /// </summary>
        /// <param name="scatteringHit">The scattering hit. This value can be null.</param>
        /// <param name="displayReference">The display form of the reference of the scattering object that was hit. This value can be null.</param>
        /// <returns>A <see cref="Classes.ScatteringHitResult"/> describing the hit, or null if the scattering hit is null.</returns>
        public static Classes.ScatteringHitResult? ScatteringHitResult(this IScatteringHit? scatteringHit, string? displayReference)
        {
            if (scatteringHit is null)
            {
                return null;
            }

            // A derived value the hit could not calculate arrives as NaN, which is not valid JSON:
            // System.Text.Json rejects it with the default number handling, so it travels as null.
            static double? Value(double value)
            {
                return double.IsNaN(value) ? null : value;
            }

            // Read once: the property clones what it returns, so every access is another deep copy.
            ElectricalProperties? electricalProperties = scatteringHit.ElectricalProperties;

            // The reflection coefficient is complex, so it has no numeric JSON form and travels already rendered.
            // An underivable one is dropped to null like every other value above: rounding leaves NaN and infinity
            // untouched, so rendering an invalid coefficient would send a string such as "NaN+jNaN". Called fully
            // qualified because this assembly declares its own Query partial class, which shadows DiGi.Core.Query
            // for unqualified use.
            Complex complex = scatteringHit.GetVerticalPolarizationReflection();
            string? verticalPolarizationReflection = DiGi.Core.Query.IsValid(complex)
                ? DiGi.Core.Convert.ToSystem_String(complex, 0.0001, 0.0001)
                : null;

            return new(
                scatteringHit.Location.Point3DResult(),
                scatteringHit.Reference,
                displayReference,
                electricalProperties.ElectricalPropertiesResult(),
                Value(scatteringHit.GetConductivity()),
                Value(scatteringHit.GetRelativePermittivity()),
                Value(scatteringHit.GetReflectionAngle()),
                Value(scatteringHit.GetGrazingAngle()),
                scatteringHit.GetVector3D(Function.Receiver).Vector3DResult(),
                scatteringHit.GetVector3D(Function.Transmitter).Vector3DResult(),
                scatteringHit.GetNormal().Vector3DResult(),
                verticalPolarizationReflection);
        }
    }
}
