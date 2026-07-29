using DiGi.Communication.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.ScatteringHitResult"/> for the propagation calculation result from the specified <see cref="IScatteringHit"/>.
        /// </summary>
        /// <param name="scatteringHit">The scattering hit. This value can be null.</param>
        /// <returns>A <see cref="Classes.ScatteringHitResult"/> holding the hit direction and the reference of the scattering object that was hit, or null if the scattering hit is null or carries no direction.</returns>
        public static Classes.ScatteringHitResult? ScatteringHitResult(this IScatteringHit? scatteringHit)
        {
            // IScatteringHit carries no location; the direction is the per hit quantity the
            // azimuth/elevation binning is derived from, and it is unnormalized (its length carries
            // the power).
            if (scatteringHit?.Ray3D?.Direction is not Vector3D vector3D_Direction)
            {
                return null;
            }

            return new(vector3D_Direction.X, vector3D_Direction.Y, vector3D_Direction.Z, scatteringHit.Reference);
        }
    }
}
