#### [DiGi\.Communication\.WebAPI](DiGi.Communication.WebAPI.Overview.md 'DiGi\.Communication\.WebAPI\.Overview')

## DiGi\.Communication\.WebAPI\.Classes Namespace
### Classes

<a name='DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult'></a>

## AngularPowerDistributionResult Class

Represents an angular power distribution of the propagation calculation result at a single location\.

The scattering hits behind the vectors are kept in their azimuth and elevation bins so the consuming application can render them as a matrix and drill down into a single bin. Only populated bins are described.

```csharp
public class AngularPowerDistributionResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → AngularPowerDistributionResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.AngularPowerDistributionResult(DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.RangeResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.RangeResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult_)'></a>

## AngularPowerDistributionResult\(Point3DResult, List\<RangeResult\>, List\<RangeResult\>, List\<ScatteringHitCellResult\>\) Constructor

Initializes a new instance of the [AngularPowerDistributionResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult 'DiGi\.Communication\.WebAPI\.Classes\.AngularPowerDistributionResult') class\.

```csharp
public AngularPowerDistributionResult(DiGi.Communication.WebAPI.Classes.Point3DResult? location, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.RangeResult>? azimuthRanges, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.RangeResult>? elevationRanges, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult>? cells);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.AngularPowerDistributionResult(DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.RangeResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.RangeResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult_).location'></a>

`location` [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

The location of the angular power distribution\.

<a name='DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.AngularPowerDistributionResult(DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.RangeResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.RangeResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult_).azimuthRanges'></a>

`azimuthRanges` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The populated azimuth bins\.

<a name='DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.AngularPowerDistributionResult(DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.RangeResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.RangeResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult_).elevationRanges'></a>

`elevationRanges` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The populated elevation bins\.

<a name='DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.AngularPowerDistributionResult(DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.RangeResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.RangeResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult_).cells'></a>

`cells` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ScatteringHitCellResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitCellResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The populated azimuth and elevation bin intersections holding the scattering hits\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.AzimuthRanges'></a>

## AngularPowerDistributionResult\.AzimuthRanges Property

Gets the populated azimuth bins\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.RangeResult> AzimuthRanges { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.Cells'></a>

## AngularPowerDistributionResult\.Cells Property

Gets the populated azimuth and elevation bin intersections holding the scattering hits\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult> Cells { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ScatteringHitCellResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitCellResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.ElevationRanges'></a>

## AngularPowerDistributionResult\.ElevationRanges Property

Gets the populated elevation bins\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.RangeResult> ElevationRanges { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.Location'></a>

## AngularPowerDistributionResult\.Location Property

Gets the location of the angular power distribution\.

```csharp
public DiGi.Communication.WebAPI.Classes.Point3DResult? Location { get; }
```

#### Property Value
[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

<a name='DiGi.Communication.WebAPI.Classes.ComplexResult'></a>

## ComplexResult Class

Represents a complex number of the propagation calculation result\.

A complex number has no numeric JSON form, so it travels as its two components. This is the computable form: a consuming application that has to aggregate complex values (averaging the reflection coefficients of a group of hits, for example) works from these numbers rather than from a rendered string.

```csharp
public class ComplexResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ComplexResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.ComplexResult.ComplexResult(double,double)'></a>

## ComplexResult\(double, double\) Constructor

Initializes a new instance of the [ComplexResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ComplexResult 'DiGi\.Communication\.WebAPI\.Classes\.ComplexResult') class\.

```csharp
public ComplexResult(double real, double imaginary);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.ComplexResult.ComplexResult(double,double).real'></a>

`real` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The real component of the complex number\.

<a name='DiGi.Communication.WebAPI.Classes.ComplexResult.ComplexResult(double,double).imaginary'></a>

`imaginary` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The imaginary component of the complex number\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.ComplexResult.Imaginary'></a>

## ComplexResult\.Imaginary Property

Gets the imaginary component of the complex number\.

```csharp
public double Imaginary { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.ComplexResult.Real'></a>

## ComplexResult\.Real Property

Gets the real component of the complex number\.

```csharp
public double Real { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.DelayResult'></a>

## DelayResult Class

Represents the part of the propagation calculation result belonging to a single delay\.

All geometry is expressed in world coordinates. The consuming application renders one delay at a time, so every collection is scoped to [Delay](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.DelayResult.Delay 'DiGi\.Communication\.WebAPI\.Classes\.DelayResult\.Delay') and is empty rather than null when the delay contributes nothing of that kind.

```csharp
public class DelayResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → DelayResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.DelayResult(double,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.EllipsoidResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.VectorGroupResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_)'></a>

## DelayResult\(double, List\<EllipsoidResult\>, List\<ScatteringPolylineResult\>, List\<VectorGroupResult\>, List\<AngularPowerDistributionResult\>\) Constructor

Initializes a new instance of the [DelayResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.DelayResult 'DiGi\.Communication\.WebAPI\.Classes\.DelayResult') class\.

```csharp
public DelayResult(double delay, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.EllipsoidResult>? ellipsoids, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult>? polylines, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.VectorGroupResult>? vectorGroups, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult>? angularDistributions);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.DelayResult(double,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.EllipsoidResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.VectorGroupResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The delay the result belongs to\.

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.DelayResult(double,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.EllipsoidResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.VectorGroupResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).ellipsoids'></a>

`ellipsoids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[EllipsoidResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The propagation ellipsoids of the delay\.

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.DelayResult(double,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.EllipsoidResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.VectorGroupResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).polylines'></a>

`polylines` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ScatteringPolylineResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringPolylineResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The scattering polylines of the delay, one per scattering point group\.

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.DelayResult(double,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.EllipsoidResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.VectorGroupResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).vectorGroups'></a>

`vectorGroups` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[VectorGroupResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.VectorGroupResult 'DiGi\.Communication\.WebAPI\.Classes\.VectorGroupResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The angular power distribution vectors of the delay, grouped by location\.

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.DelayResult(double,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.EllipsoidResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.VectorGroupResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).angularDistributions'></a>

`angularDistributions` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[AngularPowerDistributionResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult 'DiGi\.Communication\.WebAPI\.Classes\.AngularPowerDistributionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The angular power distributions of the delay\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.AngularDistributions'></a>

## DelayResult\.AngularDistributions Property

Gets the angular power distributions of the delay\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult> AngularDistributions { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[AngularPowerDistributionResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult 'DiGi\.Communication\.WebAPI\.Classes\.AngularPowerDistributionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.Delay'></a>

## DelayResult\.Delay Property

Gets the delay the result belongs to\.

```csharp
public double Delay { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.Ellipsoids'></a>

## DelayResult\.Ellipsoids Property

Gets the propagation ellipsoids of the delay\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.EllipsoidResult> Ellipsoids { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[EllipsoidResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.Polylines'></a>

## DelayResult\.Polylines Property

Gets the scattering polylines of the delay, one per scattering point group\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult> Polylines { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ScatteringPolylineResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringPolylineResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.DelayResult.VectorGroups'></a>

## DelayResult\.VectorGroups Property

Gets the angular power distribution vectors of the delay, grouped by location\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.VectorGroupResult> VectorGroups { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[VectorGroupResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.VectorGroupResult 'DiGi\.Communication\.WebAPI\.Classes\.VectorGroupResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult'></a>

## ElectricalPropertiesResult Class

Represents the electrical properties of a scattering object the propagation calculation result refers to\.

The coefficients describe the frequency dependency of the material: the relative permittivity is derived from [A](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.A 'DiGi\.Communication\.WebAPI\.Classes\.ElectricalPropertiesResult\.A') and [B](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.B 'DiGi\.Communication\.WebAPI\.Classes\.ElectricalPropertiesResult\.B'), the conductivity from [C](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.C 'DiGi\.Communication\.WebAPI\.Classes\.ElectricalPropertiesResult\.C') and [D](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.D 'DiGi\.Communication\.WebAPI\.Classes\.ElectricalPropertiesResult\.D').

```csharp
public class ElectricalPropertiesResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ElectricalPropertiesResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.ElectricalPropertiesResult(string,double,double,double,double)'></a>

## ElectricalPropertiesResult\(string, double, double, double, double\) Constructor

Initializes a new instance of the [ElectricalPropertiesResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult 'DiGi\.Communication\.WebAPI\.Classes\.ElectricalPropertiesResult') class\.

```csharp
public ElectricalPropertiesResult(string? name, double a, double b, double c, double d);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.ElectricalPropertiesResult(string,double,double,double,double).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the material\.

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.ElectricalPropertiesResult(string,double,double,double,double).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The relative permittivity coefficient\.

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.ElectricalPropertiesResult(string,double,double,double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The relative permittivity exponent\.

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.ElectricalPropertiesResult(string,double,double,double,double).c'></a>

`c` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The conductivity coefficient\.

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.ElectricalPropertiesResult(string,double,double,double,double).d'></a>

`d` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The conductivity exponent\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.A'></a>

## ElectricalPropertiesResult\.A Property

Gets the relative permittivity coefficient\.

```csharp
public double A { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.B'></a>

## ElectricalPropertiesResult\.B Property

Gets the relative permittivity exponent\.

```csharp
public double B { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.C'></a>

## ElectricalPropertiesResult\.C Property

Gets the conductivity coefficient\.

```csharp
public double C { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.D'></a>

## ElectricalPropertiesResult\.D Property

Gets the conductivity exponent\.

```csharp
public double D { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult.Name'></a>

## ElectricalPropertiesResult\.Name Property

Gets the name of the material\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult'></a>

## EllipsoidResult Class

Represents a propagation ellipsoid of the propagation calculation result in world coordinates\.

[Mesh](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult.Mesh 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult\.Mesh') is the triangulated ellipsoid cut by the horizontal plane at the lowest scattering object elevation, so only the part above the ground plane is described. It is null when no renderable geometry could be produced, in which case the consuming application falls back to the analytic parameters ([Center](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult.Center 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult\.Center'), [Axis](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult.Axis 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult\.Axis'), [SemiMajorAxis](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult.SemiMajorAxis 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult\.SemiMajorAxis') and [SemiMinorAxis](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult.SemiMinorAxis 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult\.SemiMinorAxis')).

```csharp
public class EllipsoidResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → EllipsoidResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.EllipsoidResult(DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,double,double,DiGi.Communication.WebAPI.Classes.Mesh3DResult)'></a>

## EllipsoidResult\(Point3DResult, Vector3DResult, double, double, Mesh3DResult\) Constructor

Initializes a new instance of the [EllipsoidResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.EllipsoidResult 'DiGi\.Communication\.WebAPI\.Classes\.EllipsoidResult') class\.

```csharp
public EllipsoidResult(DiGi.Communication.WebAPI.Classes.Point3DResult? center, DiGi.Communication.WebAPI.Classes.Vector3DResult? axis, double semiMajorAxis, double semiMinorAxis, DiGi.Communication.WebAPI.Classes.Mesh3DResult? mesh);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.EllipsoidResult(DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,double,double,DiGi.Communication.WebAPI.Classes.Mesh3DResult).center'></a>

`center` [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

The center of the ellipsoid\.

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.EllipsoidResult(DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,double,double,DiGi.Communication.WebAPI.Classes.Mesh3DResult).axis'></a>

`axis` [Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')

The direction of the major axis of the ellipsoid\.

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.EllipsoidResult(DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,double,double,DiGi.Communication.WebAPI.Classes.Mesh3DResult).semiMajorAxis'></a>

`semiMajorAxis` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The length of the semi major axis of the ellipsoid\.

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.EllipsoidResult(DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,double,double,DiGi.Communication.WebAPI.Classes.Mesh3DResult).semiMinorAxis'></a>

`semiMinorAxis` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The length of the semi minor axis of the ellipsoid\.

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.EllipsoidResult(DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,double,double,DiGi.Communication.WebAPI.Classes.Mesh3DResult).mesh'></a>

`mesh` [Mesh3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Mesh3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Mesh3DResult')

The triangulated geometry of the ellipsoid above the ground plane, or null when no renderable geometry could be produced\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.Axis'></a>

## EllipsoidResult\.Axis Property

Gets the direction of the major axis of the ellipsoid\.

```csharp
public DiGi.Communication.WebAPI.Classes.Vector3DResult? Axis { get; }
```

#### Property Value
[Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.Center'></a>

## EllipsoidResult\.Center Property

Gets the center of the ellipsoid\.

```csharp
public DiGi.Communication.WebAPI.Classes.Point3DResult? Center { get; }
```

#### Property Value
[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.Mesh'></a>

## EllipsoidResult\.Mesh Property

Gets the triangulated geometry of the ellipsoid above the ground plane, or null when no renderable geometry could be produced\.

```csharp
public DiGi.Communication.WebAPI.Classes.Mesh3DResult? Mesh { get; }
```

#### Property Value
[Mesh3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Mesh3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Mesh3DResult')

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.SemiMajorAxis'></a>

## EllipsoidResult\.SemiMajorAxis Property

Gets the length of the semi major axis of the ellipsoid\.

```csharp
public double SemiMajorAxis { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.EllipsoidResult.SemiMinorAxis'></a>

## EllipsoidResult\.SemiMinorAxis Property

Gets the length of the semi minor axis of the ellipsoid\.

```csharp
public double SemiMinorAxis { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult'></a>

## GeometricalPropagationResult Class

Represents the result of a geometrical propagation calculation between a transmitter and a receiver antenna, grouped by delay \(ascending\)\.

Everything is expressed in world coordinates: the propagation ellipsoids, the scattering polylines (one per scattering point group) and the angular power distribution vectors. The consuming application drives a delay slider and renders [Results](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Results 'DiGi\.Communication\.WebAPI\.Classes\.GeometricalPropagationResult\.Results') one entry at a time.

AI-NOTE (payload evolution): this is the V1 delay based payload, consumed by wwwroot/js/communication-tools.js in DiGi.GIS.WebAPI.UI (renderDelayResults, the Results and Details panels). The [Delays](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Delays 'DiGi\.Communication\.WebAPI\.Classes\.GeometricalPropagationResult\.Delays') array discriminates this V1 payload from the V2 one in that file. New fields are added as additional constructor parameters and properties on the type they belong to; the consumer tolerates unknown keys. Nulls are written rather than omitted, so a field that must stay invisible to older clients needs JsonIgnore with JsonIgnoreCondition.WhenWritingNull.

AI-NOTE (scattering hit nesting): the Details drill-down of the consuming application is two steps deep and the payload mirrors it exactly. [Cells](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.Cells 'DiGi\.Communication\.WebAPI\.Classes\.AngularPowerDistributionResult\.Cells') holds one [ScatteringHitCellResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitCellResult') per populated azimuth and elevation bin, and that cell holds the individual [ScatteringHitResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult') instances flat. An earlier form nested a per electrical properties group between the two; it was removed once a hit began carrying its own electrical properties, and re-introducing it would break the cell count the matrix renders. [Combined](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Combined 'DiGi\.Communication\.WebAPI\.Classes\.GeometricalPropagationResult\.Combined') is the same nesting with no delay key: one entry per angular power distribution profile holding the hits of all its delays at once, which the Details form offers as the Combined entry of its delay selector. Its hits are therefore the hits of [Results](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Results 'DiGi\.Communication\.WebAPI\.Classes\.GeometricalPropagationResult\.Results') a second time, binned by the hit geometry rather than grouped by delay.

AI-NOTE (serialization contract): these result types are deliberately NOT SerializableObject instances. A SerializableObject serializes as PascalCase property names plus a _type discriminator, whereas the 3D view reads the camelCase keys literally. The keys are therefore pinned by JsonPropertyName on every property, which makes them independent of the hosting application naming policy: the same instance serializes identically from this Web API and from the consuming application. Renaming a property is safe; changing an attribute value silently breaks the 3D view.

AI-NOTE (ownership): this assembly currently exposes no endpoints; the consuming application runs the solvers itself and projects the outcome through Create.GeometricalPropagationResult. Once the propagation calculation is exposed over HTTP from this assembly, this type becomes that endpoint response and the consuming application proxies it unchanged.

```csharp
public class GeometricalPropagationResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GeometricalPropagationResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.GeometricalPropagationResult(double,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_double_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.DelayResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_)'></a>

## GeometricalPropagationResult\(double, Point3DResult, Point3DResult, List\<double\>, List\<DelayResult\>, List\<AngularPowerDistributionResult\>\) Constructor

Initializes a new instance of the [GeometricalPropagationResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult 'DiGi\.Communication\.WebAPI\.Classes\.GeometricalPropagationResult') class\.

```csharp
public GeometricalPropagationResult(double distance, DiGi.Communication.WebAPI.Classes.Point3DResult? transmitter, DiGi.Communication.WebAPI.Classes.Point3DResult? receiver, System.Collections.Generic.List<double>? delays, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.DelayResult>? results, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult>? combined);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.GeometricalPropagationResult(double,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_double_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.DelayResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance between the transmitter and the receiver antenna\.

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.GeometricalPropagationResult(double,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_double_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.DelayResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).transmitter'></a>

`transmitter` [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

The location of the transmitter antenna\.

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.GeometricalPropagationResult(double,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_double_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.DelayResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).receiver'></a>

`receiver` [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

The location of the receiver antenna\.

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.GeometricalPropagationResult(double,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_double_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.DelayResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).delays'></a>

`delays` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

All available delays, ascending, one per entry of [results](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.GeometricalPropagationResult(double,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_double_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.DelayResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).results 'DiGi\.Communication\.WebAPI\.Classes\.GeometricalPropagationResult\.GeometricalPropagationResult\(double, DiGi\.Communication\.WebAPI\.Classes\.Point3DResult, DiGi\.Communication\.WebAPI\.Classes\.Point3DResult, System\.Collections\.Generic\.List\<double\>, System\.Collections\.Generic\.List\<DiGi\.Communication\.WebAPI\.Classes\.DelayResult\>, System\.Collections\.Generic\.List\<DiGi\.Communication\.WebAPI\.Classes\.AngularPowerDistributionResult\>\)\.results')\.

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.GeometricalPropagationResult(double,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_double_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.DelayResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).results'></a>

`results` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DelayResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.DelayResult 'DiGi\.Communication\.WebAPI\.Classes\.DelayResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The calculation result grouped by delay, ascending\.

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.GeometricalPropagationResult(double,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_double_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.DelayResult_,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult_).combined'></a>

`combined` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[AngularPowerDistributionResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult 'DiGi\.Communication\.WebAPI\.Classes\.AngularPowerDistributionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The angular power distributions holding the scattering hits of all delays at once, one per angular power distribution profile\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Combined'></a>

## GeometricalPropagationResult\.Combined Property

Gets the angular power distributions holding the scattering hits of all delays at once, one per angular power distribution profile\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult> Combined { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[AngularPowerDistributionResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult 'DiGi\.Communication\.WebAPI\.Classes\.AngularPowerDistributionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Delays'></a>

## GeometricalPropagationResult\.Delays Property

Gets all available delays, ascending, one per entry of [Results](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Results 'DiGi\.Communication\.WebAPI\.Classes\.GeometricalPropagationResult\.Results')\.

```csharp
public System.Collections.Generic.List<double> Delays { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Distance'></a>

## GeometricalPropagationResult\.Distance Property

Gets the distance between the transmitter and the receiver antenna\.

```csharp
public double Distance { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Receiver'></a>

## GeometricalPropagationResult\.Receiver Property

Gets the location of the receiver antenna\.

```csharp
public DiGi.Communication.WebAPI.Classes.Point3DResult? Receiver { get; }
```

#### Property Value
[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Results'></a>

## GeometricalPropagationResult\.Results Property

Gets the calculation result grouped by delay, ascending\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.DelayResult> Results { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DelayResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.DelayResult 'DiGi\.Communication\.WebAPI\.Classes\.DelayResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationResult.Transmitter'></a>

## GeometricalPropagationResult\.Transmitter Property

Gets the location of the transmitter antenna\.

```csharp
public DiGi.Communication.WebAPI.Classes.Point3DResult? Transmitter { get; }
```

#### Property Value
[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

<a name='DiGi.Communication.WebAPI.Classes.Mesh3DResult'></a>

## Mesh3DResult Class

Represents a triangulated geometry of the propagation calculation result in world coordinates\.

The geometry is flattened into two parallel buffers so it can be uploaded to the consuming application renderer without further conversion: [Vertices](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Mesh3DResult.Vertices 'DiGi\.Communication\.WebAPI\.Classes\.Mesh3DResult\.Vertices') holds the coordinates as consecutive X, Y, Z triples and [Indices](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Mesh3DResult.Indices 'DiGi\.Communication\.WebAPI\.Classes\.Mesh3DResult\.Indices') holds three vertex indices per triangle.

```csharp
public class Mesh3DResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Mesh3DResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.Mesh3DResult.Mesh3DResult(System.Collections.Generic.List_double_,System.Collections.Generic.List_int_)'></a>

## Mesh3DResult\(List\<double\>, List\<int\>\) Constructor

Initializes a new instance of the [Mesh3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Mesh3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Mesh3DResult') class\.

```csharp
public Mesh3DResult(System.Collections.Generic.List<double>? vertices, System.Collections.Generic.List<int>? indices);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.Mesh3DResult.Mesh3DResult(System.Collections.Generic.List_double_,System.Collections.Generic.List_int_).vertices'></a>

`vertices` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The vertex coordinates as consecutive X, Y, Z triples\.

<a name='DiGi.Communication.WebAPI.Classes.Mesh3DResult.Mesh3DResult(System.Collections.Generic.List_double_,System.Collections.Generic.List_int_).indices'></a>

`indices` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The vertex indices, three per triangle\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.Mesh3DResult.Indices'></a>

## Mesh3DResult\.Indices Property

Gets the vertex indices, three per triangle\.

```csharp
public System.Collections.Generic.List<int> Indices { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.Mesh3DResult.Vertices'></a>

## Mesh3DResult\.Vertices Property

Gets the vertex coordinates as consecutive X, Y, Z triples\.

```csharp
public System.Collections.Generic.List<double> Vertices { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.Point3DResult'></a>

## Point3DResult Class

Represents a location of the propagation calculation result in world coordinates\.

```csharp
public class Point3DResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Point3DResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.Point3DResult.Point3DResult(double,double,double)'></a>

## Point3DResult\(double, double, double\) Constructor

Initializes a new instance of the [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult') class\.

```csharp
public Point3DResult(double x, double y, double z);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.Point3DResult.Point3DResult(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the location\.

<a name='DiGi.Communication.WebAPI.Classes.Point3DResult.Point3DResult(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the location\.

<a name='DiGi.Communication.WebAPI.Classes.Point3DResult.Point3DResult(double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z coordinate of the location\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.Point3DResult.X'></a>

## Point3DResult\.X Property

Gets the X coordinate of the location\.

```csharp
public double X { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.Point3DResult.Y'></a>

## Point3DResult\.Y Property

Gets the Y coordinate of the location\.

```csharp
public double Y { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.Point3DResult.Z'></a>

## Point3DResult\.Z Property

Gets the Z coordinate of the location\.

```csharp
public double Z { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.RangeResult'></a>

## RangeResult Class

Represents an angular bin of the propagation calculation result\.

The bounds are expressed in radians, as everything else in this payload; the consuming application converts them for display.

```csharp
public class RangeResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → RangeResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.RangeResult.RangeResult(double,double)'></a>

## RangeResult\(double, double\) Constructor

Initializes a new instance of the [RangeResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.RangeResult 'DiGi\.Communication\.WebAPI\.Classes\.RangeResult') class\.

```csharp
public RangeResult(double min, double max);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.RangeResult.RangeResult(double,double).min'></a>

`min` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The lower bound of the bin\.

<a name='DiGi.Communication.WebAPI.Classes.RangeResult.RangeResult(double,double).max'></a>

`max` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The upper bound of the bin\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.RangeResult.Max'></a>

## RangeResult\.Max Property

Gets the upper bound of the bin\.

```csharp
public double Max { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.RangeResult.Min'></a>

## RangeResult\.Min Property

Gets the lower bound of the bin\.

```csharp
public double Min { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult'></a>

## ScatteringHitCellResult Class

Represents a populated azimuth and elevation bin of an angular power distribution of the propagation calculation result\.

[AzimuthIndex](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult.AzimuthIndex 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitCellResult\.AzimuthIndex') and [ElevationIndex](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult.ElevationIndex 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitCellResult\.ElevationIndex') address [AzimuthRanges](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.AzimuthRanges 'DiGi\.Communication\.WebAPI\.Classes\.AngularPowerDistributionResult\.AzimuthRanges') and [ElevationRanges](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.AngularPowerDistributionResult.ElevationRanges 'DiGi\.Communication\.WebAPI\.Classes\.AngularPowerDistributionResult\.ElevationRanges'). Only non-empty intersections are described: the two range lists are filtered independently, so their cross product is overwhelmingly empty.

The hits of the bin are held flat: each one carries its own electrical properties, so there is nothing left for an intermediate grouping to describe.

```csharp
public class ScatteringHitCellResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ScatteringHitCellResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult.ScatteringHitCellResult(int,int,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringHitResult_)'></a>

## ScatteringHitCellResult\(int, int, List\<ScatteringHitResult\>\) Constructor

Initializes a new instance of the [ScatteringHitCellResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitCellResult') class\.

```csharp
public ScatteringHitCellResult(int azimuthIndex, int elevationIndex, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.ScatteringHitResult>? hits);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult.ScatteringHitCellResult(int,int,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringHitResult_).azimuthIndex'></a>

`azimuthIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the azimuth bin\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult.ScatteringHitCellResult(int,int,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringHitResult_).elevationIndex'></a>

`elevationIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the elevation bin\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult.ScatteringHitCellResult(int,int,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.ScatteringHitResult_).hits'></a>

`hits` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ScatteringHitResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The scattering hits falling into the bin\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult.AzimuthIndex'></a>

## ScatteringHitCellResult\.AzimuthIndex Property

Gets the index of the azimuth bin\.

```csharp
public int AzimuthIndex { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult.ElevationIndex'></a>

## ScatteringHitCellResult\.ElevationIndex Property

Gets the index of the elevation bin\.

```csharp
public int ElevationIndex { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitCellResult.Hits'></a>

## ScatteringHitCellResult\.Hits Property

Gets the scattering hits falling into the bin\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.ScatteringHitResult> Hits { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ScatteringHitResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult'></a>

## ScatteringHitResult Class

Represents a single scattering hit of the propagation calculation result\.

Everything a hit describes is read off the hit itself: it carries its own location, its own electrical properties and the derived material and geometry values, so a consuming application needs no lookup to render a row.

The angles are sent in radians like every other angle of this payload, and the consuming application converts them for display. A value that could not be derived (missing electrical properties, missing antenna location) is sent as null rather than as NaN: NaN is not valid JSON and the serializer rejects it.

The reflection coefficient for vertical polarization is a complex number, which has no numeric JSON form, so it travels twice: [VerticalPolarizationReflection](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult.VerticalPolarizationReflection 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult\.VerticalPolarizationReflection') is the display form rendered by [DiGi\.Core\.Convert\.ToSystem\_String\(System\.Numerics\.Complex,System\.Double,System\.Double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.convert.tosystem_string#digi-core-convert-tosystem_string(system-numerics-complex-system-double-system-double) 'DiGi\.Core\.Convert\.ToSystem\_String\(System\.Numerics\.Complex,System\.Double,System\.Double\)'), the canonical rendering of a complex number in this project, and [VerticalPolarizationReflectionValue](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult.VerticalPolarizationReflectionValue 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult\.VerticalPolarizationReflectionValue') is the same value as its two components. The display form saves every consuming application from reimplementing that rendering; the components are there because a rendered string cannot be aggregated, and the hits of an azimuth and elevation bin are averaged by the consuming application (the bins the payload describes are finer than the ones it displays, so the aggregation cannot be done here).

[VectorReceiver](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult.VectorReceiver 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult\.VectorReceiver'), [VectorTransmitter](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult.VectorTransmitter 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult\.VectorTransmitter') and [Normal](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult.Normal 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult\.Normal') are unit vectors, unlike the angular power distribution vectors of [VectorGroupResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.VectorGroupResult 'DiGi\.Communication\.WebAPI\.Classes\.VectorGroupResult'), whose length carries the power.

```csharp
public class ScatteringHitResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ScatteringHitResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult)'></a>

## ScatteringHitResult\(Point3DResult, string, string, ElectricalPropertiesResult, Nullable\<double\>, Nullable\<double\>, Nullable\<double\>, Nullable\<double\>, Vector3DResult, Vector3DResult, Vector3DResult, string, ComplexResult\) Constructor

Initializes a new instance of the [ScatteringHitResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult') class\.

```csharp
public ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult? location, string? reference, string? displayReference, DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult? electricalProperties, System.Nullable<double> conductivity, System.Nullable<double> relativePermittivity, System.Nullable<double> reflectionAngle, System.Nullable<double> grazingAngle, DiGi.Communication.WebAPI.Classes.Vector3DResult? vectorReceiver, DiGi.Communication.WebAPI.Classes.Vector3DResult? vectorTransmitter, DiGi.Communication.WebAPI.Classes.Vector3DResult? normal, string? verticalPolarizationReflection, DiGi.Communication.WebAPI.Classes.ComplexResult? verticalPolarizationReflectionValue);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).location'></a>

`location` [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

The location of the hit point in world coordinates\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference of the scattering object that was hit\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).displayReference'></a>

`displayReference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display form of the reference of the scattering object that was hit\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).electricalProperties'></a>

`electricalProperties` [ElectricalPropertiesResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult 'DiGi\.Communication\.WebAPI\.Classes\.ElectricalPropertiesResult')

The electrical properties of the scattering object that was hit\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).conductivity'></a>

`conductivity` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The material conductivity \[S/m\] at the operating frequency\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).relativePermittivity'></a>

`relativePermittivity` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The material relative permittivity at the operating frequency\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).reflectionAngle'></a>

`reflectionAngle` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The reflection angle \[rad\] relative to the surface normal\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).grazingAngle'></a>

`grazingAngle` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The grazing angle \[rad\] relative to the surface tangent plane\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).vectorReceiver'></a>

`vectorReceiver` [Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')

The unit direction vector from the hit point towards the receiver\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).vectorTransmitter'></a>

`vectorTransmitter` [Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')

The unit direction vector from the transmitter towards the hit point\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).normal'></a>

`normal` [Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')

The unit surface normal vector at the hit point\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).verticalPolarizationReflection'></a>

`verticalPolarizationReflection` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The complex reflection coefficient for vertical polarization, already rendered as a string\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ScatteringHitResult(DiGi.Communication.WebAPI.Classes.Point3DResult,string,string,DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,DiGi.Communication.WebAPI.Classes.Vector3DResult,string,DiGi.Communication.WebAPI.Classes.ComplexResult).verticalPolarizationReflectionValue'></a>

`verticalPolarizationReflectionValue` [ComplexResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ComplexResult 'DiGi\.Communication\.WebAPI\.Classes\.ComplexResult')

The complex reflection coefficient for vertical polarization as its two components\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.Conductivity'></a>

## ScatteringHitResult\.Conductivity Property

Gets the material conductivity \[S/m\] at the operating frequency, or null if it could not be derived\.

```csharp
public System.Nullable<double> Conductivity { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.DisplayReference'></a>

## ScatteringHitResult\.DisplayReference Property

Gets the display form of [Reference](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult.Reference 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult\.Reference'): the unique identifier of the last step of the reference chain\.

A reference of a scattering object runs to a few hundred characters, which is unreadable in a table cell, so its last step is sent alongside it for display; the consuming application shows this value and keeps the full [Reference](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult.Reference 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult\.Reference') as the hover text.

Null when the reference is null, empty, or not a parseable reference chain, in which case the consuming application falls back to the full [Reference](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult.Reference 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult\.Reference').

```csharp
public string? DisplayReference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ElectricalProperties'></a>

## ScatteringHitResult\.ElectricalProperties Property

Gets the electrical properties of the scattering object that was hit, or null if it carries none\.

```csharp
public DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult? ElectricalProperties { get; }
```

#### Property Value
[ElectricalPropertiesResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ElectricalPropertiesResult 'DiGi\.Communication\.WebAPI\.Classes\.ElectricalPropertiesResult')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.GrazingAngle'></a>

## ScatteringHitResult\.GrazingAngle Property

Gets the grazing angle \[rad\] relative to the surface tangent plane, or null if it could not be derived\.

```csharp
public System.Nullable<double> GrazingAngle { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.Location'></a>

## ScatteringHitResult\.Location Property

Gets the location of the hit point in world coordinates, or null if the hit carries none\.

```csharp
public DiGi.Communication.WebAPI.Classes.Point3DResult? Location { get; }
```

#### Property Value
[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.Normal'></a>

## ScatteringHitResult\.Normal Property

Gets the unit surface normal vector at the hit point, or null if it could not be derived\.

```csharp
public DiGi.Communication.WebAPI.Classes.Vector3DResult? Normal { get; }
```

#### Property Value
[Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.Reference'></a>

## ScatteringHitResult\.Reference Property

Gets the reference of the scattering object that was hit\.

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.ReflectionAngle'></a>

## ScatteringHitResult\.ReflectionAngle Property

Gets the reflection angle \[rad\] relative to the surface normal, or null if it could not be derived\.

```csharp
public System.Nullable<double> ReflectionAngle { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.RelativePermittivity'></a>

## ScatteringHitResult\.RelativePermittivity Property

Gets the material relative permittivity at the operating frequency, or null if it could not be derived\.

```csharp
public System.Nullable<double> RelativePermittivity { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.VectorReceiver'></a>

## ScatteringHitResult\.VectorReceiver Property

Gets the unit direction vector from the hit point towards the receiver, or null if it could not be derived\.

```csharp
public DiGi.Communication.WebAPI.Classes.Vector3DResult? VectorReceiver { get; }
```

#### Property Value
[Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.VectorTransmitter'></a>

## ScatteringHitResult\.VectorTransmitter Property

Gets the unit direction vector from the transmitter towards the hit point, or null if it could not be derived\.

```csharp
public DiGi.Communication.WebAPI.Classes.Vector3DResult? VectorTransmitter { get; }
```

#### Property Value
[Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.VerticalPolarizationReflection'></a>

## ScatteringHitResult\.VerticalPolarizationReflection Property

Gets the complex reflection coefficient for vertical polarization, rendered as "\{real\}\{\+\|\-\}j\{imaginary\}", or null if it could not be derived\.

```csharp
public string? VerticalPolarizationReflection { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringHitResult.VerticalPolarizationReflectionValue'></a>

## ScatteringHitResult\.VerticalPolarizationReflectionValue Property

Gets the complex reflection coefficient for vertical polarization as its two components, or null if it could not be derived\. This is the form to aggregate; [VerticalPolarizationReflection](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringHitResult.VerticalPolarizationReflection 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringHitResult\.VerticalPolarizationReflection') is the form to display\.

```csharp
public DiGi.Communication.WebAPI.Classes.ComplexResult? VerticalPolarizationReflectionValue { get; }
```

#### Property Value
[ComplexResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ComplexResult 'DiGi\.Communication\.WebAPI\.Classes\.ComplexResult')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult'></a>

## ScatteringPolylineResult Class

Represents a scattering polyline of the propagation calculation result in world coordinates, one per scattering point group\.

[Reference](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.Reference 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringPolylineResult\.Reference') identifies the component the group was created for. [Location1](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.Location1 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringPolylineResult\.Location1') and [Location2](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.Location2 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringPolylineResult\.Location2') are the locations of the scattering profile the group belongs to; they enable the auxiliary polylines (location 1 to point to location 2) the consuming application draws when the polyline is selected.

```csharp
public class ScatteringPolylineResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ScatteringPolylineResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.ScatteringPolylineResult(string,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.Point3DResult_)'></a>

## ScatteringPolylineResult\(string, Point3DResult, Point3DResult, List\<Point3DResult\>\) Constructor

Initializes a new instance of the [ScatteringPolylineResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult 'DiGi\.Communication\.WebAPI\.Classes\.ScatteringPolylineResult') class\.

```csharp
public ScatteringPolylineResult(string? reference, DiGi.Communication.WebAPI.Classes.Point3DResult? location1, DiGi.Communication.WebAPI.Classes.Point3DResult? location2, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.Point3DResult>? points);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.ScatteringPolylineResult(string,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.Point3DResult_).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference of the component the scattering point group was created for\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.ScatteringPolylineResult(string,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.Point3DResult_).location1'></a>

`location1` [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

The first location of the scattering profile\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.ScatteringPolylineResult(string,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.Point3DResult_).location2'></a>

`location2` [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

The second location of the scattering profile\.

<a name='DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.ScatteringPolylineResult(string,DiGi.Communication.WebAPI.Classes.Point3DResult,DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.Point3DResult_).points'></a>

`points` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The points of the polyline\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.Location1'></a>

## ScatteringPolylineResult\.Location1 Property

Gets the first location of the scattering profile\.

```csharp
public DiGi.Communication.WebAPI.Classes.Point3DResult? Location1 { get; }
```

#### Property Value
[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.Location2'></a>

## ScatteringPolylineResult\.Location2 Property

Gets the second location of the scattering profile\.

```csharp
public DiGi.Communication.WebAPI.Classes.Point3DResult? Location2 { get; }
```

#### Property Value
[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.Points'></a>

## ScatteringPolylineResult\.Points Property

Gets the points of the polyline\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.Point3DResult> Points { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.WebAPI.Classes.ScatteringPolylineResult.Reference'></a>

## ScatteringPolylineResult\.Reference Property

Gets the reference of the component the scattering point group was created for\.

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.WebAPI.Classes.Vector3DResult'></a>

## Vector3DResult Class

Represents a direction of the propagation calculation result in world coordinates\.

The vectors are sent unnormalized: their length carries the power, so the consuming application scales them for display instead of recovering the magnitude.

```csharp
public class Vector3DResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Vector3DResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.Vector3DResult.Vector3DResult(double,double,double)'></a>

## Vector3DResult\(double, double, double\) Constructor

Initializes a new instance of the [Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult') class\.

```csharp
public Vector3DResult(double x, double y, double z);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.Vector3DResult.Vector3DResult(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component of the direction\.

<a name='DiGi.Communication.WebAPI.Classes.Vector3DResult.Vector3DResult(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component of the direction\.

<a name='DiGi.Communication.WebAPI.Classes.Vector3DResult.Vector3DResult(double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component of the direction\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.Vector3DResult.X'></a>

## Vector3DResult\.X Property

Gets the X component of the direction\.

```csharp
public double X { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.Vector3DResult.Y'></a>

## Vector3DResult\.Y Property

Gets the Y component of the direction\.

```csharp
public double Y { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.Vector3DResult.Z'></a>

## Vector3DResult\.Z Property

Gets the Z component of the direction\.

```csharp
public double Z { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.WebAPI.Classes.VectorGroupResult'></a>

## VectorGroupResult Class

Represents the angular power distribution vectors of the propagation calculation result visualized at a single location\.

The vectors are sent unnormalized: their length carries the power, so the consuming application scales them for display.

```csharp
public class VectorGroupResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → VectorGroupResult
### Constructors

<a name='DiGi.Communication.WebAPI.Classes.VectorGroupResult.VectorGroupResult(DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.Vector3DResult_)'></a>

## VectorGroupResult\(Point3DResult, List\<Vector3DResult\>\) Constructor

Initializes a new instance of the [VectorGroupResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.VectorGroupResult 'DiGi\.Communication\.WebAPI\.Classes\.VectorGroupResult') class\.

```csharp
public VectorGroupResult(DiGi.Communication.WebAPI.Classes.Point3DResult? location, System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.Vector3DResult>? vectors);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.VectorGroupResult.VectorGroupResult(DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.Vector3DResult_).location'></a>

`location` [Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

The location the vectors are visualized at\.

<a name='DiGi.Communication.WebAPI.Classes.VectorGroupResult.VectorGroupResult(DiGi.Communication.WebAPI.Classes.Point3DResult,System.Collections.Generic.List_DiGi.Communication.WebAPI.Classes.Vector3DResult_).vectors'></a>

`vectors` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The vectors visualized at the location\.
### Properties

<a name='DiGi.Communication.WebAPI.Classes.VectorGroupResult.Location'></a>

## VectorGroupResult\.Location Property

Gets the location the vectors are visualized at\.

```csharp
public DiGi.Communication.WebAPI.Classes.Point3DResult? Location { get; }
```

#### Property Value
[Point3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Point3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Point3DResult')

<a name='DiGi.Communication.WebAPI.Classes.VectorGroupResult.Vectors'></a>

## VectorGroupResult\.Vectors Property

Gets the vectors visualized at the location\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.WebAPI.Classes.Vector3DResult> Vectors { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Vector3DResult](DiGi.Communication.WebAPI.Classes.md#DiGi.Communication.WebAPI.Classes.Vector3DResult 'DiGi\.Communication\.WebAPI\.Classes\.Vector3DResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')