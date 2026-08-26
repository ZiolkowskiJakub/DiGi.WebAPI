using DiGi.WebAPI.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds identity and version metadata for a loaded assembly.
    /// </summary>
    public class AssemblyInformation : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(FullName))]
        private readonly string? fullName;

        [JsonInclude, JsonPropertyName(nameof(InformationalVersion))]
        private readonly string? informationalVersion;

        [JsonInclude, JsonPropertyName(nameof(IsDynamic))]
        private readonly bool isDynamic;

        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(Version))]
        private readonly string? version;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyInformation"/> class.
        /// </summary>
        /// <param name="name">The simple name of the assembly.</param>
        /// <param name="fullName">The full assembly display name.</param>
        /// <param name="version">The assembly version.</param>
        /// <param name="informationalVersion">The assembly informational version (e.g., git commit).</param>
        /// <param name="isDynamic">Whether the assembly is dynamic.</param>
        public AssemblyInformation(string? name, string? fullName, string? version, string? informationalVersion, bool isDynamic)
            : base()
        {
            this.name = name;
            this.fullName = fullName;
            this.version = version;
            this.informationalVersion = informationalVersion;
            this.isDynamic = isDynamic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyInformation"/> class by copying from another instance.
        /// </summary>
        /// <param name="assemblyInformation">The <see cref="AssemblyInformation"/> to copy from.</param>
        public AssemblyInformation(AssemblyInformation? assemblyInformation)
            : base(assemblyInformation)
        {
            if (assemblyInformation is not null)
            {
                name = assemblyInformation.name;
                fullName = assemblyInformation.fullName;
                version = assemblyInformation.version;
                informationalVersion = assemblyInformation.informationalVersion;
                isDynamic = assemblyInformation.isDynamic;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyInformation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public AssemblyInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the full assembly display name.
        /// </summary>
        [JsonIgnore]
        public string? FullName
        {
            get
            {
                return fullName;
            }
        }

        /// <summary>
        /// Gets the assembly informational version (e.g., git commit).
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
        /// Gets a value indicating whether the assembly is dynamic.
        /// </summary>
        [JsonIgnore]
        public bool IsDynamic
        {
            get
            {
                return isDynamic;
            }
        }

        /// <summary>
        /// Gets the simple name of the assembly.
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
        /// Gets the assembly version.
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
