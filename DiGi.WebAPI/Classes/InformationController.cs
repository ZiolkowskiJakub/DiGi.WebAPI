using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Provides API endpoints for retrieving controller metadata and application version information.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(IgnoreApi = false)]
    public class InformationController : WebAPIController
    {
        /// <summary>
        /// Manages application parts for controller discovery.
        /// </summary>
        private readonly ApplicationPartManager applicationPartManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="InformationController"/> class.
        /// </summary>
        /// <param name="applicationPartManager">The application part manager used for controller discovery.</param>
        public InformationController(ApplicationPartManager applicationPartManager)
        {
            this.applicationPartManager = applicationPartManager;
        }

        /// <summary>
        /// Retrieves a list of all registered controllers in the application.
        /// </summary>
        /// <returns>A JSON string containing controller information, or an empty response if no controllers are found.</returns>
        [HttpGet("controllers", Name = $"{nameof(InformationController)}_{nameof(GetControllersAsync)}")]
        [ProducesResponseType(typeof(List<ControllerInformation>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetControllersAsync()
        {
            ControllerFeature controllerFeature = new ();
            applicationPartManager.PopulateFeature(controllerFeature);

            IList<TypeInfo>? typeInfos = controllerFeature?.Controllers;
            if (typeInfos is null)
            {
                return NoContent();
            }

            List<ControllerInformation> controllerInformations = [];
            foreach (TypeInfo typeInfo in typeInfos)
            {
                ControllerInformation? controllerInformation = Create.ControllerInformation(typeInfo);
                if (controllerInformation is not null)
                {
                    controllerInformations.Add(controllerInformation);
                }
            }

            string? json = Core.Convert.ToSystem_String(controllerInformations);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NoContent();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Retrieves the version of the executing assembly.
        /// </summary>
        /// <returns>The assembly version as a string, or an empty response if unavailable.</returns>
        [HttpGet("version", Name = $"{nameof(InformationController)}_{nameof(GetVersionAsync)}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetVersionAsync()
        {
            // Fully removed the controller feature processing logic here.
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string? version = executingAssembly?.GetName()?.Version?.ToString();

            if (string.IsNullOrWhiteSpace(version))
            {
                return NoContent();
            }

            return Ok(version);
        }
    }
}