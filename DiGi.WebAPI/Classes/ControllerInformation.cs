using DiGi.WebAPI.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds metadata about a controller, including its name, assembly information, and version.
    /// </summary>
    public class ControllerInformation : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerInformation"/> class by copying from another instance.
        /// </summary>
        /// <param name="controllerInformation">The <see cref="ControllerInformation"/> to copy from.</param>
        public ControllerInformation(ControllerInformation? controllerInformation)
            : base(controllerInformation)
        {
            if (controllerInformation is not null)
            {
                Name = controllerInformation.Name;
                AssemblyName = controllerInformation.AssemblyName;
                Version = controllerInformation.Version;
                InformationalVersion = controllerInformation.InformationalVersion;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerInformation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public ControllerInformation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerInformation"/> class with the specified metadata.
        /// </summary>
        /// <param name="name">The controller name.</param>
        /// <param name="assemblyName">The name of the assembly containing the controller.</param>
        /// <param name="version">The assembly version.</param>
        /// <param name="informationalVersion">The informational version of the assembly.</param>
        public ControllerInformation(string? name, string? assemblyName, string? version, string? informationalVersion)
            : base()
        {
            Name = name;
            AssemblyName = assemblyName;
            Version = version;
            InformationalVersion = informationalVersion;
        }

        /// <summary>
        /// Gets the name of the assembly containing the controller.
        /// </summary>
        [JsonInclude, JsonPropertyName("AssemblyName")]
        public string? AssemblyName { get; }

        /// <summary>
        /// Gets the informational version of the assembly.
        /// </summary>
        [JsonInclude, JsonPropertyName("InformationalVersion")]
        public string? InformationalVersion { get; }

        /// <summary>
        /// Gets the name of the controller.
        /// </summary>
        [JsonInclude, JsonPropertyName("Name")]
        public string? Name { get; }

        /// <summary>
        /// Gets the version of the assembly containing the controller.
        /// </summary>
        [JsonInclude, JsonPropertyName("Version")]
        public string? Version { get; }
    }
}