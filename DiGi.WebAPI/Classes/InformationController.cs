using DiGi.WebAPI.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Provides API endpoints for remote diagnosis, health checks, endpoint cataloging, assembly auditing, and system telemetry with tiered access protection.
    /// <para>Protected endpoints read the access key from the <c>key</c> request header and deny by default; see <see cref="DiagnosticsConfiguration"/>.</para>
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(IgnoreApi = false)]
    public class InformationController : WebAPIController
    {
        private readonly IActionDescriptorCollectionProvider? actionDescriptorCollectionProvider;
        private readonly ApplicationPartManager applicationPartManager;
        private readonly DiagnosticsConfiguration diagnosticsConfiguration;
        private readonly IHostEnvironment? hostEnvironment;

        /// <summary>
        /// Initializes a new instance of the <see cref="InformationController"/> class.
        /// </summary>
        /// <param name="applicationPartManager">The application part manager used for controller discovery.</param>
        /// <param name="actionDescriptorCollectionProvider">Optional action descriptor collection provider for route cataloging.</param>
        /// <param name="hostEnvironment">Optional host environment descriptor.</param>
        /// <param name="diagnosticsConfiguration">Optional diagnostics configuration for access key validation. When not supplied by dependency injection it is loaded from disk, which is a per-request cost - register it as a singleton on the host.</param>
        public InformationController(ApplicationPartManager applicationPartManager, IActionDescriptorCollectionProvider? actionDescriptorCollectionProvider = null, IHostEnvironment? hostEnvironment = null, DiagnosticsConfiguration? diagnosticsConfiguration = null)
        {
            this.applicationPartManager = applicationPartManager;
            this.actionDescriptorCollectionProvider = actionDescriptorCollectionProvider;
            this.hostEnvironment = hostEnvironment;
            this.diagnosticsConfiguration = diagnosticsConfiguration ?? Create.DiagnosticsConfiguration();
        }

        /// <summary>
        /// Retrieves an inventory of loaded assemblies in the default assembly load context. Requires a valid key.
        /// </summary>
        /// <param name="key">Access key supplied through the <c>key</c> request header.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the request.</param>
        /// <returns>A JSON list of loaded assembly metadata.</returns>
        [HttpGet("assemblies", Name = $"{nameof(InformationController)}_{nameof(GetAssembliesAsync)}")]
        [ProducesResponseType(typeof(List<AssemblyInformation>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetAssembliesAsync([FromHeader(Name = "key")] string? key = null, CancellationToken cancellationToken = default)
        {
            if (!diagnosticsConfiguration.IsAuthorized(key))
            {
                return Unauthorized();
            }

            List<AssemblyInformation> assemblyInformations = [];

            foreach (Assembly assembly in AssemblyLoadContext.Default.Assemblies)
            {
                AssemblyInformation? assemblyInformation = Create.AssemblyInformation(assembly);
                if (assemblyInformation is not null)
                {
                    assemblyInformations.Add(assemblyInformation);
                }
            }

            if (assemblyInformations.Count == 0)
            {
                return NoContent();
            }

            string? json = Core.Convert.ToSystem_String(assemblyInformations);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NoContent();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Retrieves a list of all registered controllers in the application. Requires a valid key.
        /// </summary>
        /// <param name="key">Access key supplied through the <c>key</c> request header.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the request.</param>
        /// <returns>A JSON string containing controller information, or an empty response if no controllers are found.</returns>
        [HttpGet("controllers", Name = $"{nameof(InformationController)}_{nameof(GetControllersAsync)}")]
        [ProducesResponseType(typeof(List<ControllerInformation>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetControllersAsync([FromHeader(Name = "key")] string? key = null, CancellationToken cancellationToken = default)
        {
            if (!diagnosticsConfiguration.IsAuthorized(key))
            {
                return Unauthorized();
            }

            ControllerFeature controllerFeature = new();
            applicationPartManager.PopulateFeature(controllerFeature);

            IList<TypeInfo>? typeInfos = controllerFeature?.Controllers;
            if (typeInfos is null || typeInfos.Count == 0)
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
        /// Retrieves the catalog of registered action routes and parameter contracts. Inspecting internal routes requires a valid key.
        /// </summary>
        /// <param name="controller">Optional controller name filter.</param>
        /// <param name="includeIgnored">Whether to include endpoints hidden from Swagger explorer. Defaults to false for safe public exposure.</param>
        /// <param name="key">Access key supplied through the <c>key</c> request header, required when includeignored is set to true.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the request.</param>
        /// <returns>A JSON list of endpoint metadata.</returns>
        [HttpGet("endpoints", Name = $"{nameof(InformationController)}_{nameof(GetEndpointsAsync)}")]
        [ProducesResponseType(typeof(List<EndpointInformation>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetEndpointsAsync([FromQuery(Name = "controller")] string? controller, [FromQuery(Name = "includeignored")] bool includeIgnored = false, [FromHeader(Name = "key")] string? key = null, CancellationToken cancellationToken = default)
        {
            if (includeIgnored && !diagnosticsConfiguration.IsAuthorized(key))
            {
                return Unauthorized();
            }

            if (actionDescriptorCollectionProvider is null)
            {
                return NoContent();
            }

            IReadOnlyList<ActionDescriptor> actionDescriptors = actionDescriptorCollectionProvider.ActionDescriptors.Items;
            if (actionDescriptors is null || actionDescriptors.Count == 0)
            {
                return NoContent();
            }

            List<EndpointInformation> endpointInformations = [];

            foreach (ActionDescriptor actionDescriptor in actionDescriptors)
            {
                EndpointInformation? endpointInformation = Create.EndpointInformation(actionDescriptor);
                if (endpointInformation is null)
                {
                    continue;
                }

                if (!includeIgnored && endpointInformation.IsApiIgnored)
                {
                    continue;
                }

                if (!string.IsNullOrWhiteSpace(controller))
                {
                    string controllerName = endpointInformation.ControllerName ?? string.Empty;
                    bool matches = controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase) ||
                                   controllerName.Equals($"{controller}Controller", StringComparison.OrdinalIgnoreCase);

                    if (!matches)
                    {
                        continue;
                    }
                }

                endpointInformations.Add(endpointInformation);
            }

            if (endpointInformations.Count == 0)
            {
                return NoContent();
            }

            string? json = Core.Convert.ToSystem_String(endpointInformations);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NoContent();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Retrieves service health status, server UTC/local timestamps, uptime, and process ID.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the request.</param>
        /// <returns>The service health information.</returns>
        [HttpGet("health", Name = $"{nameof(InformationController)}_{nameof(GetHealthAsync)}")]
        [ProducesResponseType(typeof(ServiceHealthInformation), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetHealthAsync(CancellationToken cancellationToken = default)
        {
            ServiceHealthInformation serviceHealthInformation = Create.ServiceHealthInformation();

            string? json = Core.Convert.ToSystem_String(serviceHealthInformation);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NoContent();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Retrieves host system, environment, memory, and thread pool diagnostic information. Requires a valid key.
        /// </summary>
        /// <param name="key">Access key supplied through the <c>key</c> request header.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the request.</param>
        /// <returns>The system telemetry information.</returns>
        [HttpGet("system", Name = $"{nameof(InformationController)}_{nameof(GetSystemAsync)}")]
        [ProducesResponseType(typeof(SystemInformation), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetSystemAsync([FromHeader(Name = "key")] string? key = null, CancellationToken cancellationToken = default)
        {
            if (!diagnosticsConfiguration.IsAuthorized(key))
            {
                return Unauthorized();
            }

            SystemInformation systemInformation = Create.SystemInformation(hostEnvironment);

            string? json = Core.Convert.ToSystem_String(systemInformation);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NoContent();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Retrieves comprehensive version and runtime diagnostic information across the service host, WebAPI framework, and .NET CLR.
        /// <para>The source control commit hash is appended to the informational versions only for callers supplying a valid key, because it identifies the exact revision of a publicly readable repository.</para>
        /// </summary>
        /// <param name="key">Optional access key supplied through the <c>key</c> request header. When valid, commit hashes are included.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the request.</param>
        /// <returns>The version and runtime metadata.</returns>
        [HttpGet("version", Name = $"{nameof(InformationController)}_{nameof(GetVersionAsync)}")]
        [ProducesResponseType(typeof(VersionInformation), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetVersionAsync([FromHeader(Name = "key")] string? key = null, CancellationToken cancellationToken = default)
        {
            VersionInformation versionInformation = Create.VersionInformation(diagnosticsConfiguration.IsAuthorized(key));

            string? json = Core.Convert.ToSystem_String(versionInformation);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NoContent();
            }

            return Content(json, "application/json");
        }
    }
}