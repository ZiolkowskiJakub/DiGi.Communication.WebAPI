# DiGi.Communication.WebAPI

Web API extension exposing the [DiGi.Communication](../DiGi.Communication) radio propagation models over HTTP. The extension is loaded by the generic `DiGi.WebAPI.WindowsService` host (from its `extensions` directory) and serves its endpoints under the `communication/` route prefix — the counterpart of `DiGi.GIS.PostgreSQL.WebAPI`, which serves the `gis/` prefix.

## Design rules

- **No GIS references.** Neither this extension nor `DiGi.Communication` references any GIS library. Consuming applications convert their domain objects (e.g. buildings) into `ScatteringObject` instances (`Building -> Mesh3D -> ScatteringObject`) before calling the endpoints.
- **No database.** All results are calculated on the fly by the server; nothing is persisted.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `communication/geometricalpropagationmodel/segment3d` | Temporary endpoint: accepts a serialized `GeometricalPropagationModel` holding exactly two antennas (plus optional `ScatteringObject` instances) and returns a `Segment3D` connecting the two antenna locations. It will be replaced by the full propagation calculation returning calculation objects (scattering profiles, rays, power delay profiles). |

## Solution structure

- `DiGi.Communication.WebAPI/Classes/Controller` — API controllers (`WebAPIController` implementations discovered by the hosting service).
- `DiGi.Communication.WebAPI/Modify/InitializeAsync.cs` — extension initialization entry point invoked by the hosting service.

## Dependencies

Referenced by relative `HintPath` (the solution folder must sit directly under the `DigiProject` workspace root): `DiGi.Core`, `DiGi.Core.Relation`, `DiGi.Geometry`, `DiGi.Communication`, `DiGi.Serilog`, `DiGi.WebAPI`.
