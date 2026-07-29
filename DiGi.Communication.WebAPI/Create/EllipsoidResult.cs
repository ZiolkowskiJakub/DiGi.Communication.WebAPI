using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Communication.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates an <see cref="Classes.EllipsoidResult"/> for the propagation calculation result from the specified propagation <see cref="Ellipsoid"/>.
        /// </summary>
        /// <param name="ellipsoid">The propagation ellipsoid in world coordinates. This value can be null.</param>
        /// <param name="minElevation">The elevation of the ground plane the ellipsoid mesh is cut by.</param>
        /// <returns>An <see cref="Classes.EllipsoidResult"/> holding the analytic parameters and the triangulated geometry of the part of the ellipsoid above the ground plane, or null if the ellipsoid is null or carries no center or major axis direction.</returns>
        public static Classes.EllipsoidResult? EllipsoidResult(this Ellipsoid? ellipsoid, double minElevation)
        {
            if (ellipsoid?.Center is not Point3D point3D_Center || ellipsoid.DirectionA is not Vector3D vector3D_Axis)
            {
                return null;
            }

            // The propagation ellipsoid is meshed and cut by the horizontal plane at the lowest
            // scattering object elevation: only the part above the ground plane is rendered by the
            // 3D view, so the result carries the triangulated world coordinate mesh (flat
            // vertex/index arrays) instead of the analytic ellipsoid parameters.
            // Called statically rather than as an extension: this class shadows both
            // DiGi.Geometry.Spatial.Create and DiGi.Communication.Create for unqualified use inside
            // the DiGi.Communication.WebAPI namespace.
            Mesh3D? mesh3D = DiGi.Geometry.Spatial.Create.Mesh3D(ellipsoid, DiGi.Communication.Constants.Factor.Angle);

            List<Mesh3D> mesh3Ds = [];
            if (DiGi.Geometry.Spatial.Query.TrySplit(DiGi.Geometry.Spatial.Create.Plane(minElevation), mesh3D, out List<Mesh3D>? mesh3Ds_Above, out List<Mesh3D>? _) && mesh3Ds_Above is not null && mesh3Ds_Above.Count > 0)
            {
                mesh3Ds.AddRange(mesh3Ds_Above);
            }
            else if (mesh3D is not null)
            {
                // No split available (e.g. the ellipsoid does not cross the plane): fall back to the
                // full ellipsoid mesh.
                mesh3Ds.Add(mesh3D);
            }

            return new(point3D_Center.Point3DResult(), vector3D_Axis.Vector3DResult(), ellipsoid.A, ellipsoid.B, mesh3Ds.Mesh3DResult());
        }
    }
}
