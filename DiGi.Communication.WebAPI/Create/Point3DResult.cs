using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.Point3DResult"/> for the propagation calculation result from the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The location in world coordinates. This value can be null.</param>
        /// <returns>A <see cref="Classes.Point3DResult"/> holding the coordinates of the location, or null if the location is null.</returns>
        public static Classes.Point3DResult? Point3DResult(this Point3D? point3D)
        {
            if (point3D is null)
            {
                return null;
            }

            return new(point3D.X, point3D.Y, point3D.Z);
        }

        /// <summary>
        /// Creates the <see cref="Classes.Point3DResult"/> instances for the propagation calculation result from the specified <see cref="Point3D"/> instances, skipping the ones that could not be converted.
        /// </summary>
        /// <param name="point3Ds">The locations in world coordinates. This value can be null.</param>
        /// <returns>The <see cref="Classes.Point3DResult"/> instances holding the coordinates of the locations. The list is empty rather than null when there is nothing to convert.</returns>
        public static List<Classes.Point3DResult> Point3DResults(this IEnumerable<Point3D>? point3Ds)
        {
            List<Classes.Point3DResult> point3DResults = [];
            if (point3Ds is null)
            {
                return point3DResults;
            }

            foreach (Point3D point3D in point3Ds)
            {
                if (point3D.Point3DResult() is Classes.Point3DResult point3DResult)
                {
                    point3DResults.Add(point3DResult);
                }
            }

            return point3DResults;
        }
    }
}
