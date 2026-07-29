#### [DiGi\.Communication\.WebAPI](index.md 'index')

## DiGi\.Communication\.WebAPI Namespace
### Classes

<a name='DiGi.Communication.WebAPI.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Communication.WebAPI.Create.ElectricalPropertiesResult(thisDiGi.Communication.Classes.ElectricalProperties)'></a>

## Create\.ElectricalPropertiesResult\(this ElectricalProperties\) Method

Creates an [ElectricalPropertiesResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult 'DiGi\.Communication\.WebAPI\.Classes\.ElectricalPropertiesResult') for the propagation calculation result from the specified [DiGi\.Communication\.Classes\.ElectricalProperties](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.electricalproperties 'DiGi\.Communication\.Classes\.ElectricalProperties')\.

```csharp
public static DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult? ElectricalPropertiesResult(this DiGi.Communication.Classes.ElectricalProperties? electricalProperties);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.ElectricalPropertiesResult(thisDiGi.Communication.Classes.ElectricalProperties).electricalProperties'></a>

`electricalProperties` [DiGi\.Communication\.Classes\.ElectricalProperties](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.electricalproperties 'DiGi\.Communication\.Classes\.ElectricalProperties')

The electrical properties of a scattering object\. This value can be null\.

#### Returns
[ElectricalPropertiesResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult 'DiGi\.Communication\.WebAPI\.Classes\.ElectricalPropertiesResult')  
An [ElectricalPropertiesResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult 'DiGi\.Communication\.WebAPI\.Classes\.ElectricalPropertiesResult') holding the name and the frequency dependency coefficients of the material, or null if the electrical properties are null\.

<a name='DiGi.Communication.WebAPI.Create.EllipsoidResult(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,double)'></a>

## Create\.EllipsoidResult\(this Ellipsoid, double\) Method

Creates an [EllipsoidResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult') for the propagation calculation result from the specified propagation [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')\.

```csharp
public static DiGi.Communication.WebAPI.Classes.EllipsoidResult? EllipsoidResult(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid, double minElevation);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.EllipsoidResult(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,double).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The propagation ellipsoid in world coordinates\. This value can be null\.

<a name='DiGi.Communication.WebAPI.Create.EllipsoidResult(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,double).minElevation'></a>

`minElevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation of the ground plane the ellipsoid mesh is cut by\.

#### Returns
[EllipsoidResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult')  
An [EllipsoidResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult') holding the analytic parameters and the triangulated geometry of the part of the ellipsoid above the ground plane, or null if the ellipsoid is null or carries no center or major axis direction\.

<a name='DiGi.Communication.WebAPI.Create.GeometricalPropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Create\.GeometricalPropagationResult\(this GeometricalPropagationModel, Point3D, Point3D, double\) Method

Creates a [GeometricalPropagationResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult 'DiGi\.Communication\.WebAPI\.Classes\.GeometricalPropagationResult') from the specified solved [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')\.

The model must already have been solved ([DiGi\.Communication\.Classes\.ScatteringSolver](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringsolver 'DiGi\.Communication\.Classes\.ScatteringSolver') followed by [DiGi\.Communication\.Classes\.AngularPowerDistributionSolver](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.angularpowerdistributionsolver 'DiGi\.Communication\.Classes\.AngularPowerDistributionSolver')); this method only projects the calculation objects it holds into the result payload and never calculates anything itself.

```csharp
public static DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult? GeometricalPropagationResult(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel, DiGi.Geometry.Spatial.Classes.Point3D? transmitter, DiGi.Geometry.Spatial.Classes.Point3D? receiver, double minElevation);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.GeometricalPropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).geometricalPropagationModel'></a>

`geometricalPropagationModel` [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The solved geometrical propagation model\. This value can be null\.

<a name='DiGi.Communication.WebAPI.Create.GeometricalPropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).transmitter'></a>

`transmitter` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The location of the transmitter antenna in world coordinates\. This value can be null\.

<a name='DiGi.Communication.WebAPI.Create.GeometricalPropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).receiver'></a>

`receiver` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The location of the receiver antenna in world coordinates\. This value can be null\.

<a name='DiGi.Communication.WebAPI.Create.GeometricalPropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).minElevation'></a>

`minElevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation of the ground plane the propagation ellipsoid meshes are cut by, normally the lowest scattering object elevation\.

#### Returns
[GeometricalPropagationResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult 'DiGi\.Communication\.WebAPI\.Classes\.GeometricalPropagationResult')  
A [GeometricalPropagationResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult 'DiGi\.Communication\.WebAPI\.Classes\.GeometricalPropagationResult') grouped by delay \(ascending\), or null if the model or either antenna location is null, or if the model holds no delays to describe\.

<a name='DiGi.Communication.WebAPI.Create.Mesh3DResult(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_)'></a>

## Create\.Mesh3DResult\(this IEnumerable\<Mesh3D\>\) Method

Creates a [Mesh3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Mesh3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Mesh3DResult') for the propagation calculation result by flattening the specified [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') instances into one pair of vertex and index buffers\.

The meshes are merged rather than kept apart: the consuming application uploads the result as a single geometry, so the vertex indices of every mesh after the first are offset by the number of vertices already written.

```csharp
public static DiGi.Communication.WebAPI.Classes.Mesh3DResult? Mesh3DResult(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Mesh3D>? mesh3Ds);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.Mesh3DResult(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_).mesh3Ds'></a>

`mesh3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The triangulated geometry in world coordinates\. This value can be null\.

#### Returns
[Mesh3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Mesh3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Mesh3DResult')  
A [Mesh3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Mesh3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Mesh3DResult') holding the flattened vertex and index buffers, or null if no renderable geometry could be produced\.

<a name='DiGi.Communication.WebAPI.Create.Point3DResult(thisDiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Create\.Point3DResult\(this Point3D\) Method

Creates a [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult') for the propagation calculation result from the specified [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public static DiGi.Communication.WebAPI.Classes.Point3DResult? Point3DResult(this DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.Point3DResult(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The location in world coordinates\. This value can be null\.

#### Returns
[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')  
A [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult') holding the coordinates of the location, or null if the location is null\.

<a name='DiGi.Communication.WebAPI.Create.Point3DResults(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Create\.Point3DResults\(this IEnumerable\<Point3D\>\) Method

Creates the [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult') instances for the propagation calculation result from the specified [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instances, skipping the ones that could not be converted\.

```csharp
public static System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.Point3DResult> Point3DResults(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.Point3DResults(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The locations in world coordinates\. This value can be null\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult') instances holding the coordinates of the locations\. The list is empty rather than null when there is nothing to convert\.

<a name='DiGi.Communication.WebAPI.Create.RangeResult(thisDiGi.Core.Classes.Range_double_)'></a>

## Create\.RangeResult\(this Range\<double\>\) Method

Creates a [RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult') for the propagation calculation result from the specified angular bin\.

The bounds are copied in radians, as everything else in the propagation calculation result.

```csharp
public static DiGi.Communication.WebAPI.Classes.RangeResult? RangeResult(this DiGi.Core.Classes.Range<double>? range);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.RangeResult(thisDiGi.Core.Classes.Range_double_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The angular bin\. This value can be null\.

#### Returns
[RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult')  
A [RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult') holding the bounds of the bin, or null if the bin is null\.

<a name='DiGi.Communication.WebAPI.Create.RangeResults(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_double__)'></a>

## Create\.RangeResults\(this IEnumerable\<Range\<double\>\>\) Method

Creates the [RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult') instances for the propagation calculation result from the specified angular bins, skipping the ones that could not be converted\.

```csharp
public static System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.RangeResult> RangeResults(this System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Range<double>>? ranges);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.RangeResults(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_double__).ranges'></a>

`ranges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The angular bins\. This value can be null\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The [RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult') instances holding the bounds of the bins\. The list is empty rather than null when there is nothing to convert\.

<a name='DiGi.Communication.WebAPI.Create.ScatteringHitResult(thisDiGi.Communication.Interfaces.IScatteringHit)'></a>

## Create\.ScatteringHitResult\(this IScatteringHit\) Method

Creates a [ScatteringHitResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult') for the propagation calculation result from the specified [DiGi\.Communication\.Interfaces\.IScatteringHit](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringhit 'DiGi\.Communication\.Interfaces\.IScatteringHit')\.

```csharp
public static DiGi.Communication.WebAPI.Classes.ScatteringHitResult? ScatteringHitResult(this DiGi.Communication.Interfaces.IScatteringHit? scatteringHit);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.ScatteringHitResult(thisDiGi.Communication.Interfaces.IScatteringHit).scatteringHit'></a>

`scatteringHit` [DiGi\.Communication\.Interfaces\.IScatteringHit](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringhit 'DiGi\.Communication\.Interfaces\.IScatteringHit')

The scattering hit\. This value can be null\.

#### Returns
[ScatteringHitResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult')  
A [ScatteringHitResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult') holding the hit direction and the reference of the scattering object that was hit, or null if the scattering hit is null or carries no direction\.

<a name='DiGi.Communication.WebAPI.Create.ScatteringHitResult(thisDiGi.Communication.Interfaces.IScatteringHit,string)'></a>

## Create\.ScatteringHitResult\(this IScatteringHit, string\) Method

Creates a [ScatteringHitResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult') for the propagation calculation result from the specified [DiGi\.Communication\.Interfaces\.IScatteringHit](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringhit 'DiGi\.Communication\.Interfaces\.IScatteringHit') and the display form of its reference\.

The display form is supplied by the caller rather than derived here so it can be resolved once per distinct reference: [DisplayReference\(this string\)](DiGi.Communication.WebAPI.md#DiGi.Communication.WebAPI.Query.DisplayReference(thisstring) 'DiGi\.Communication\.WebAPI\.Query\.DisplayReference\(this string\)') parses the whole reference chain, which is wasted work when repeated for every hit pointing at the same scattering object.

```csharp
public static DiGi.Communication.WebAPI.Classes.ScatteringHitResult? ScatteringHitResult(this DiGi.Communication.Interfaces.IScatteringHit? scatteringHit, string? displayReference);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.ScatteringHitResult(thisDiGi.Communication.Interfaces.IScatteringHit,string).scatteringHit'></a>

`scatteringHit` [DiGi\.Communication\.Interfaces\.IScatteringHit](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringhit 'DiGi\.Communication\.Interfaces\.IScatteringHit')

The scattering hit\. This value can be null\.

<a name='DiGi.Communication.WebAPI.Create.ScatteringHitResult(thisDiGi.Communication.Interfaces.IScatteringHit,string).displayReference'></a>

`displayReference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display form of the reference of the scattering object that was hit\. This value can be null\.

#### Returns
[ScatteringHitResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult')  
A [ScatteringHitResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult') holding the hit direction and the reference of the scattering object that was hit, or null if the scattering hit is null or carries no direction\.

<a name='DiGi.Communication.WebAPI.Create.Vector3DResult(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Create\.Vector3DResult\(this Vector3D\) Method

Creates a [Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult') for the propagation calculation result from the specified [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

The vector is copied unnormalized: its length carries the power and is scaled by the consuming application only.

```csharp
public static DiGi.Communication.WebAPI.Classes.Vector3DResult? Vector3DResult(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.Vector3DResult(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The direction in world coordinates\. This value can be null\.

#### Returns
[Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')  
A [Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult') holding the components of the direction, or null if the direction is null\.

<a name='DiGi.Communication.WebAPI.Create.Vector3DResults(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Vector3D_)'></a>

## Create\.Vector3DResults\(this IEnumerable\<Vector3D\>\) Method

Creates the [Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult') instances for the propagation calculation result from the specified [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') instances, skipping the ones that could not be converted\.

```csharp
public static System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.Vector3DResult> Vector3DResults(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Vector3D>? vector3Ds);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Create.Vector3DResults(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Vector3D_).vector3Ds'></a>

`vector3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The directions in world coordinates\. This value can be null\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The [Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult') instances holding the components of the directions\. The list is empty rather than null when there is nothing to convert\.

<a name='DiGi.Communication.WebAPI.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Communication.WebAPI.Modify.InitializeAsync(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection)'></a>

## Modify\.InitializeAsync\(this IServiceCollection\) Method

Initializes the Communication Web API services required by its controllers\.

This method is the extension initialization entry point invoked by the hosting service; the controllers currently require no additional services.

```csharp
public static System.Threading.Tasks.Task InitializeAsync(this Microsoft.Extensions.DependencyInjection.IServiceCollection serviceCollection);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Modify.InitializeAsync(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).serviceCollection'></a>

`serviceCollection` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add services to\.

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')  
A [System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task') representing the asynchronous operation\.

<a name='DiGi.Communication.WebAPI.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Communication.WebAPI.Query.DisplayReference(thisstring)'></a>

## Query\.DisplayReference\(this string\) Method

Gets the display form of a rendered reference: the unique identifier of the last step of the reference chain, or of the reference itself when it is not a chain\.

A reference of a scattering object runs to a few hundred characters, which is unreadable in a table cell. The last step is the one that addresses the object itself, so it identifies the reference well enough to be shown on its own while the full string stays available as hover text.

```csharp
public static string? DisplayReference(this string? reference);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Query.DisplayReference(thisstring).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The rendered reference to reduce\. This value can be null\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The unique identifier of the last step of the chain, or null when the reference is null, empty, not a parseable reference, or resolves to a step that carries no unique identifier\.