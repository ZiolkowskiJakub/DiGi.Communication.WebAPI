using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.Vector3DResult"/> for the propagation calculation result from the specified <see cref="Vector3D"/>.
        /// <para>The vector is copied unnormalized: its length carries the power and is scaled by the consuming application only.</para>
        /// </summary>
        /// <param name="vector3D">The direction in world coordinates. This value can be null.</param>
        /// <returns>A <see cref="Classes.Vector3DResult"/> holding the components of the direction, or null if the direction is null.</returns>
        public static Classes.Vector3DResult? Vector3DResult(this Vector3D? vector3D)
        {
            if (vector3D is null)
            {
                return null;
            }

            return new(vector3D.X, vector3D.Y, vector3D.Z);
        }

        /// <summary>
        /// Creates the <see cref="Classes.Vector3DResult"/> instances for the propagation calculation result from the specified <see cref="Vector3D"/> instances, skipping the ones that could not be converted.
        /// </summary>
        /// <param name="vector3Ds">The directions in world coordinates. This value can be null.</param>
        /// <returns>The <see cref="Classes.Vector3DResult"/> instances holding the components of the directions. The list is empty rather than null when there is nothing to convert.</returns>
        public static List<Classes.Vector3DResult> Vector3DResults(this IEnumerable<Vector3D>? vector3Ds)
        {
            List<Classes.Vector3DResult> vector3DResults = [];
            if (vector3Ds is null)
            {
                return vector3DResults;
            }

            foreach (Vector3D vector3D in vector3Ds)
            {
                if (vector3D.Vector3DResult() is Classes.Vector3DResult vector3DResult)
                {
                    vector3DResults.Add(vector3DResult);
                }
            }

            return vector3DResults;
        }
    }
}
