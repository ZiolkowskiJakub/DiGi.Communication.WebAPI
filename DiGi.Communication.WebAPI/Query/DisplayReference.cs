using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Communication.WebAPI
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the display form of a rendered reference: the unique identifier of the last step of the reference chain, or of the reference itself when it is not a chain.
        /// <para>A reference of a scattering object runs to a few hundred characters, which is unreadable in a table cell. The last step is the one that addresses the object itself, so it identifies the reference well enough to be shown on its own while the full string stays available as hover text.</para>
        /// </summary>
        /// <param name="reference">The rendered reference to reduce. This value can be null.</param>
        /// <returns>The unique identifier of the last step of the chain, or null when the reference is null, empty, not a parseable reference, or resolves to a step that carries no unique identifier.</returns>
        public static string? DisplayReference(this string? reference)
        {
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            // ComplexReference has no string constructor and no Parse of its own; a rendered reference
            // is parsed back through DiGi.Core.Query. Called fully qualified because this assembly
            // declares its own Query partial class, which shadows DiGi.Core.Query for unqualified use
            // inside the DiGi.Communication.WebAPI namespace.
            if (!DiGi.Core.Query.TryParse(reference, out IReference? reference_Parsed) || reference_Parsed is null)
            {
                return null;
            }

            // A ComplexReference is deliberately not an IUniqueReference - a chain has no unique
            // identifier of its own - so for a chain the identifier comes from its last step, which is
            // the one addressing the object itself. Not every reference is a chain: the reference of a
            // scattering object is a single step whenever there is no containing object to address it
            // through, and that step carries its own identifier.
            if (reference_Parsed is ComplexReference complexReference)
            {
                if (complexReference.Count == 0)
                {
                    return null;
                }

                reference_Parsed = complexReference[complexReference.Count - 1];
            }

            // For a GuidReference this is the guid in "N" format, 32 hex characters without dashes.
            if (reference_Parsed is not IUniqueReference uniqueReference)
            {
                return null;
            }

            return uniqueReference.UniqueId;
        }
    }
}
