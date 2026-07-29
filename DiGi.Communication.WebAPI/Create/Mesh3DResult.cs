using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.Mesh3DResult"/> for the propagation calculation result by flattening the specified <see cref="Mesh3D"/> instances into one pair of vertex and index buffers.
        /// <para>The meshes are merged rather than kept apart: the consuming application uploads the result as a single geometry, so the vertex indices of every mesh after the first are offset by the number of vertices already written.</para>
        /// </summary>
        /// <param name="mesh3Ds">The triangulated geometry in world coordinates. This value can be null.</param>
        /// <returns>A <see cref="Classes.Mesh3DResult"/> holding the flattened vertex and index buffers, or null if no renderable geometry could be produced.</returns>
        public static Classes.Mesh3DResult? Mesh3DResult(this IEnumerable<Mesh3D>? mesh3Ds)
        {
            if (mesh3Ds is null)
            {
                return null;
            }

            List<double> vertices = [];
            List<int> indices = [];
            foreach (Mesh3D mesh3D_Temp in mesh3Ds)
            {
                List<Point3D>? point3Ds = mesh3D_Temp?.GetPoints();
                List<int[]>? indexes = mesh3D_Temp?.GetIndexes();
                if (point3Ds is null || indexes is null)
                {
                    continue;
                }

                int indexOffset = vertices.Count / 3;
                foreach (Point3D point3D in point3Ds)
                {
                    vertices.Add(point3D.X);
                    vertices.Add(point3D.Y);
                    vertices.Add(point3D.Z);
                }

                foreach (int[] triangle in indexes)
                {
                    if (triangle is null || triangle.Length < 3)
                    {
                        continue;
                    }

                    indices.Add(triangle[0] + indexOffset);
                    indices.Add(triangle[1] + indexOffset);
                    indices.Add(triangle[2] + indexOffset);
                }
            }

            if (vertices.Count == 0 || indices.Count == 0)
            {
                return null;
            }

            return new(vertices, indices);
        }
    }
}
