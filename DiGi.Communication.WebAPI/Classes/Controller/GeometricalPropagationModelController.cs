using DiGi.Communication.Classes;
using DiGi.WebAPI.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Controller responsible for evaluating <see cref="GeometricalPropagationModel"/> payloads sent by consuming applications.
    /// <para>The controller is GIS agnostic: buildings and other obstacles arrive already converted into <see cref="ScatteringObject"/> instances (triangulated <see cref="Geometry.Spatial.Classes.Mesh3D"/> geometry), so this extension never references any GIS library. All results are calculated on the fly; nothing is persisted.</para>
    /// </summary>
    [ApiController]
    [Route("communication/[controller]")]
    public class GeometricalPropagationModelController : WebAPIController
    {
        // AI-NOTE (temporary endpoint): This action is a placeholder used to wire the client/server
        // round trip while the propagation calculation is being developed. The final architecture:
        //   1. The client sends a GeometricalPropagationModel holding two antennas and the
        //      ScatteringObject instances of all buildings in the analyzed area (Building -> Mesh3D
        //      -> ScatteringObject conversion is done by the consuming application, which owns the
        //      GIS references).
        //   2. This controller runs the propagation calculation (scattering / multipath power delay
        //      solvers from DiGi.Communication and DiGi.Communication.ComputeSharp) and returns the
        //      resulting calculation objects (e.g. scattering profiles, rays, power delay profiles).
        //   3. The consuming application renders the returned calculation objects in its 3D view.
        // Until then the endpoint validates the payload and returns a Segment3D connecting the two
        // antenna locations, which the client renders as a temporary line of sight.

        /// <summary>
        /// Temporary endpoint: validates the provided <see cref="GeometricalPropagationModel"/> and returns a <see cref="Geometry.Spatial.Classes.Segment3D"/> connecting the locations of its two antennas.
        /// <para>This action will be replaced by the full propagation calculation returning calculation objects (scattering profiles, rays, power delay profiles) to be rendered by the consuming application.</para>
        /// </summary>
        /// <param name="jsonObject">The JSON object with the serialized <see cref="GeometricalPropagationModel"/> holding exactly two antennas and optional <see cref="ScatteringObject"/> instances.</param>
        /// <returns>An <see cref="IActionResult"/> holding the <see cref="Geometry.Spatial.Classes.Segment3D"/> JSON.</returns>
        [HttpPost("segment3d", Name = $"{nameof(GeometricalPropagationModelController)}_{nameof(Segment3D)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(Geometry.Spatial.Classes.Segment3D), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Segment3D([FromBody] JsonObject? jsonObject)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(GeometricalPropagationModelController), nameof(Segment3D));

            if (jsonObject is null)
            {
                return BadRequest();
            }

            GeometricalPropagationModel? geometricalPropagationModel = Core.Create.SerializableObject<GeometricalPropagationModel>(jsonObject);
            if (geometricalPropagationModel is null)
            {
                return BadRequest();
            }

            List<Antenna>? antennas = geometricalPropagationModel.GetAntennas<Antenna>();
            if (antennas is null || antennas.Count != 2)
            {
                return BadRequest();
            }

            Geometry.Spatial.Classes.Point3D? location_1 = antennas[0].Location;
            Geometry.Spatial.Classes.Point3D? location_2 = antennas[1].Location;
            if (location_1 is null || location_2 is null)
            {
                return NoContent();
            }

            // AI-NOTE: The final implementation will consume geometricalPropagationModel.GetScatteringObjects<ScatteringObject>()
            // here and hand the whole model to the propagation solver instead of connecting the antennas directly.
            Geometry.Spatial.Classes.Segment3D segment3D = new(location_1, location_2);

            string? json = Core.Convert.ToSystem_String(segment3D);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NoContent();
            }

            return Content(json, "application/json");
        }
    }
}
