using DiGi.WebAPI.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    public class ControllerInformation : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
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

        public ControllerInformation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public ControllerInformation(string? name, string? assemblyName, string? version, string? informationalVersion)
            : base()
        {
            Name = name;
            AssemblyName = assemblyName;
            Version = version;
            InformationalVersion = informationalVersion;
        }

        [JsonInclude, JsonPropertyName("AssemblyName")]
        public string? AssemblyName { get; }

        [JsonInclude, JsonPropertyName("InformationalVersion")]
        public string? InformationalVersion { get; }

        [JsonInclude, JsonPropertyName("Name")]
        public string? Name { get; }

        [JsonInclude, JsonPropertyName("Version")]
        public string? Version { get; }
    }
}