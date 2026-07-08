using DiGi.Communication.Classes;
using DiGi.Communication.Propagation;
using DiGi.Communication.Propagation.Enums;
using DiGi.WebAPI.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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

        /// <summary>
        /// Executes the multi-ellipsoidal propagation calculation for the provided <see cref="GeometricalPropagationModel"/>, once per requested frequency.
        /// <para>The geometrical model is converted into the propagation model input data (see DiGi.Communication.Propagation Convert.ToPropagation_PropagationModel) using the provided frequency, polarization and electrical material properties, and the full three stage comparative analysis cascade is executed.</para>
        /// <para>The response is a JSON array with one element per successfully calculated frequency: <c>{ "Frequency": [MHz], "PropagationResult": { ... } }</c>. The array shape is the extensibility point for the multi-frequency comparison requested by the consuming applications.</para>
        /// </summary>
        /// <param name="jsonObject">The JSON object with the serialized <see cref="GeometricalPropagationModel"/> holding the antennas, the scattering objects and the assigned multipath power delay profile.</param>
        /// <param name="frequencies">The frequencies of the propagating electromagnetic wave [MHz]; repeat the query parameter to calculate multiple frequencies at once.</param>
        /// <param name="polarization">The polarization type of the propagating electromagnetic wave (Vertical or Horizontal); defaults to Vertical.</param>
        /// <param name="relativePermittivity">The default relative electrical permittivity applied to the scattering object mesh cells [-].</param>
        /// <param name="conductivity">The default electrical conductivity applied to the scattering object mesh cells [S/m].</param>
        /// <returns>An <see cref="IActionResult"/> holding the JSON array of the per frequency propagation results.</returns>
        [HttpPost("propagationresults", Name = $"{nameof(GeometricalPropagationModelController)}_{nameof(PropagationResults)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PropagationResults([FromBody] JsonObject? jsonObject, [FromQuery(Name = "frequency")] List<double>? frequencies, [FromQuery(Name = "polarization")] string? polarization = null, [FromQuery(Name = "relativePermittivity")] double relativePermittivity = double.NaN, [FromQuery(Name = "conductivity")] double conductivity = double.NaN)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(GeometricalPropagationModelController), nameof(PropagationResults));

            if (jsonObject is null || frequencies is null || frequencies.Count == 0 || double.IsNaN(relativePermittivity) || double.IsNaN(conductivity))
            {
                return BadRequest();
            }

            GeometricalPropagationModel? geometricalPropagationModel = Core.Create.SerializableObject<GeometricalPropagationModel>(jsonObject);
            if (geometricalPropagationModel is null)
            {
                return BadRequest();
            }

            if (!Enum.TryParse(polarization, true, out Polarization polarization_Temp))
            {
                polarization_Temp = Polarization.Vertical;
            }

            Propagation.Classes.MaterialProperties materialProperties = new(relativePermittivity, conductivity);

            // AI-NOTE (placeholder antenna characteristics): the normalized radiation/reception
            // characteristics are not part of the serialized GeometricalPropagationModel (they are
            // runtime delegates). Until the antenna definitions carry real radiation patterns, the
            // constant mock characteristics of the reference xUnit fact
            // (DiGi.Communication.Propagation.xUnit Facts.ToPropagation_PropagationModel_TypicalUrban)
            // are used: unit omnidirectional characteristics and a directional reception
            // characteristic of constant value 2 (so the directional power equals 2 for a normalized
            // Power Delay Profile). Replace these delegates with characteristics resolved from the
            // antenna definitions once available.
            AntennaCharacteristic receivingDirectionalCharacteristic = (theta, phi) => 2.0;
            AntennaCharacteristic omnidirectionalCharacteristic = (theta, phi) => 1.0;

            JsonArray jsonArray = [];
            foreach (double frequency in frequencies)
            {
                // AI-NOTE (per object materials): the default material properties are applied to all
                // scattering objects; pass a per reference dictionary as the last argument once the
                // consuming applications provide per building materials.
                Propagation.Classes.PropagationResult? propagationResult = geometricalPropagationModel.PropagationResult(frequency, polarization_Temp, materialProperties, receivingDirectionalCharacteristic, omnidirectionalCharacteristic, omnidirectionalCharacteristic);
                if (propagationResult is null)
                {
                    continue;
                }

                string? json_PropagationResult = Core.Convert.ToSystem_String(propagationResult);
                if (string.IsNullOrWhiteSpace(json_PropagationResult))
                {
                    continue;
                }

                jsonArray.Add(new JsonObject
                {
                    ["Frequency"] = frequency,
                    ["PropagationResult"] = JsonNode.Parse(json_PropagationResult)
                });
            }

            if (jsonArray.Count == 0)
            {
                return NoContent();
            }

            return Content(jsonArray.ToJsonString(), "application/json");
        }
    }
}
