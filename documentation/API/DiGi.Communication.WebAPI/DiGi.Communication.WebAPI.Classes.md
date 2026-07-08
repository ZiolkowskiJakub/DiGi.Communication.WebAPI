#### [DiGi\.Communication\.WebAPI](index.md 'index')

## DiGi\.Communication\.WebAPI\.Classes Namespace
### Classes

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationModelController'></a>

## GeometricalPropagationModelController Class

Controller responsible for evaluating [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel') payloads sent by consuming applications\.

The controller is GIS agnostic: buildings and other obstacles arrive already converted into [DiGi\.Communication\.Classes\.ScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringobject 'DiGi\.Communication\.Classes\.ScatteringObject') instances (triangulated [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') geometry), so this extension never references any GIS library. All results are calculated on the fly; nothing is persisted.

```csharp
public class GeometricalPropagationModelController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → GeometricalPropagationModelController
### Methods

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationModelController.PropagationResults(System.Text.Json.Nodes.JsonObject,System.Collections.Generic.List_double_,string,double,double)'></a>

## GeometricalPropagationModelController\.PropagationResults\(JsonObject, List\<double\>, string, double, double\) Method

Executes the multi\-ellipsoidal propagation calculation for the provided [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel'), once per requested frequency\.

The geometrical model is converted into the propagation model input data (see DiGi.Communication.Propagation Convert.ToPropagation_PropagationModel) using the provided frequency, polarization and electrical material properties, and the full three stage comparative analysis cascade is executed.

The response is a JSON array with one element per successfully calculated frequency: `{ "Frequency": [MHz], "PropagationResult": { ... } }`. The array shape is the extensibility point for the multi-frequency comparison requested by the consuming applications.

```csharp
public Microsoft.AspNetCore.Mvc.IActionResult PropagationResults(System.Text.Json.Nodes.JsonObject? jsonObject, System.Collections.Generic.List<double>? frequencies, string? polarization=null, double relativePermittivity=double.NaN, double conductivity=double.NaN);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationModelController.PropagationResults(System.Text.Json.Nodes.JsonObject,System.Collections.Generic.List_double_,string,double,double).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object with the serialized [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel') holding the antennas, the scattering objects and the assigned multipath power delay profile\.

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationModelController.PropagationResults(System.Text.Json.Nodes.JsonObject,System.Collections.Generic.List_double_,string,double,double).frequencies'></a>

`frequencies` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The frequencies of the propagating electromagnetic wave \[MHz\]; repeat the query parameter to calculate multiple frequencies at once\.

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationModelController.PropagationResults(System.Text.Json.Nodes.JsonObject,System.Collections.Generic.List_double_,string,double,double).polarization'></a>

`polarization` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The polarization type of the propagating electromagnetic wave \(Vertical or Horizontal\); defaults to Vertical\.

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationModelController.PropagationResults(System.Text.Json.Nodes.JsonObject,System.Collections.Generic.List_double_,string,double,double).relativePermittivity'></a>

`relativePermittivity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The default relative electrical permittivity applied to the scattering object mesh cells \[\-\]\.

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationModelController.PropagationResults(System.Text.Json.Nodes.JsonObject,System.Collections.Generic.List_double_,string,double,double).conductivity'></a>

`conductivity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The default electrical conductivity applied to the scattering object mesh cells \[S/m\]\.

#### Returns
[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') holding the JSON array of the per frequency propagation results\.

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationModelController.Segment3D(System.Text.Json.Nodes.JsonObject)'></a>

## GeometricalPropagationModelController\.Segment3D\(JsonObject\) Method

Temporary endpoint: validates the provided [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel') and returns a [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') connecting the locations of its two antennas\.

This action will be replaced by the full propagation calculation returning calculation objects (scattering profiles, rays, power delay profiles) to be rendered by the consuming application.

```csharp
public Microsoft.AspNetCore.Mvc.IActionResult Segment3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.WebAPI.Classes.GeometricalPropagationModelController.Segment3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object with the serialized [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel') holding exactly two antennas and optional [DiGi\.Communication\.Classes\.ScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringobject 'DiGi\.Communication\.Classes\.ScatteringObject') instances\.

#### Returns
[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') holding the [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') JSON\.