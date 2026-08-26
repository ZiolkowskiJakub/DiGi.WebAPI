using DiGi.WebAPI.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds metadata about a controller, including its name, assembly information, version, action count, and route prefix.
    /// </summary>
    public class ControllerInformation : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(ActionCount))]
        private readonly int actionCount;

        [JsonInclude, JsonPropertyName(nameof(AssemblyName))]
        private readonly string? assemblyName;

        [JsonInclude, JsonPropertyName(nameof(InformationalVersion))]
        private readonly string? informationalVersion;

        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(RoutePrefix))]
        private readonly string? routePrefix;

        [JsonInclude, JsonPropertyName(nameof(Version))]
        private readonly string? version;

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerInformation"/> class with the specified metadata.
        /// </summary>
        /// <param name="name">The controller name.</param>
        /// <param name="assemblyName">The name of the assembly containing the controller.</param>
        /// <param name="version">The assembly version.</param>
        /// <param name="informationalVersion">The informational version of the assembly.</param>
        public ControllerInformation(string? name, string? assemblyName, string? version, string? informationalVersion)
            : this(name, assemblyName, version, informationalVersion, 0, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerInformation"/> class with the specified metadata, action count, and route prefix.
        /// </summary>
        /// <param name="name">The controller name.</param>
        /// <param name="assemblyName">The name of the assembly containing the controller.</param>
        /// <param name="version">The assembly version.</param>
        /// <param name="informationalVersion">The informational version of the assembly.</param>
        /// <param name="actionCount">The number of registered actions on the controller.</param>
        /// <param name="routePrefix">The route template prefix declared on the controller.</param>
        public ControllerInformation(string? name, string? assemblyName, string? version, string? informationalVersion, int actionCount, string? routePrefix)
            : base()
        {
            this.name = name;
            this.assemblyName = assemblyName;
            this.version = version;
            this.informationalVersion = informationalVersion;
            this.actionCount = actionCount;
            this.routePrefix = routePrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerInformation"/> class by copying from another instance.
        /// </summary>
        /// <param name="controllerInformation">The <see cref="ControllerInformation"/> to copy from.</param>
        public ControllerInformation(ControllerInformation? controllerInformation)
            : base(controllerInformation)
        {
            if (controllerInformation is not null)
            {
                name = controllerInformation.name;
                assemblyName = controllerInformation.assemblyName;
                version = controllerInformation.version;
                informationalVersion = controllerInformation.informationalVersion;
                actionCount = controllerInformation.actionCount;
                routePrefix = controllerInformation.routePrefix;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerInformation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public ControllerInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the count of registered actions on the controller.
        /// </summary>
        [JsonIgnore]
        public int ActionCount
        {
            get
            {
                return actionCount;
            }
        }

        /// <summary>
        /// Gets the name of the assembly containing the controller.
        /// </summary>
        [JsonIgnore]
        public string? AssemblyName
        {
            get
            {
                return assemblyName;
            }
        }

        /// <summary>
        /// Gets the informational version of the assembly.
        /// </summary>
        [JsonIgnore]
        public string? InformationalVersion
        {
            get
            {
                return informationalVersion;
            }
        }

        /// <summary>
        /// Gets the name of the controller.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the route template prefix configured for the controller.
        /// </summary>
        [JsonIgnore]
        public string? RoutePrefix
        {
            get
            {
                return routePrefix;
            }
        }

        /// <summary>
        /// Gets the version of the assembly containing the controller.
        /// </summary>
        [JsonIgnore]
        public string? Version
        {
            get
            {
                return version;
            }
        }
    }
}