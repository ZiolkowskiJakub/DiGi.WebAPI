using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace DiGi.WebAPI.Classes
{
    [ApiController]
    [Route("api/[controller]")]
    public class InformationController : WebAPIController
    {
        private readonly ApplicationPartManager applicationPartManager;

        public InformationController(ApplicationPartManager applicationPartManager)
        {
            this.applicationPartManager = applicationPartManager;
        }

        [HttpGet("controllers")]
        public async Task<IActionResult> GetControllersAsync()
        {
            ControllerFeature controllerFeature = new();
            applicationPartManager.PopulateFeature(controllerFeature);

            IList<TypeInfo>? typeInfos = controllerFeature?.Controllers;
            if (typeInfos is null)
            {
                return Ok();
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

            return Ok(Core.Convert.ToSystem_String(controllerInformations));
        }

        [HttpGet("version")]
        public async Task<IActionResult> GetVersionAsync()
        {
            ControllerFeature controllerFeature = new();
            applicationPartManager.PopulateFeature(controllerFeature);

            IList<TypeInfo>? typeInfos = controllerFeature?.Controllers;
            if (typeInfos is null)
            {
                return Ok();
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

            return Ok(Assembly.GetExecutingAssembly()?.GetName()?.Version?.ToString());
        }
    }
}