using DiGi.WebAPI.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds the identity and build stamp of a single loaded extension assembly for the public version tier.
    /// <para>Deliberately minimal: only the simple name and the informational version are exposed, so the public response stays
    /// coarser than the protected <c>/information/assemblies</c> inventory. The source control commit hash is trimmed for
    /// unauthenticated callers by <c>Create.VersionInformation</c> and kept only for authorized ones.</para>
    /// </summary>
    public class ExtensionVersionInformation : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(InformationalVersion))]
        private readonly string? informationalVersion;

        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionVersionInformation"/> class.
        /// </summary>
        /// <param name="name">The simple name of the extension assembly.</param>
        /// <param name="informationalVersion">The extension assembly informational version, e.g. <c>0.8.8.20260908111220</c>.</param>
        public ExtensionVersionInformation(string? name, string? informationalVersion)
            : base()
        {
            this.name = name;
            this.informationalVersion = informationalVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionVersionInformation"/> class by copying from another instance.
        /// </summary>
        /// <param name="extensionVersionInformation">The <see cref="ExtensionVersionInformation"/> to copy from.</param>
        public ExtensionVersionInformation(ExtensionVersionInformation? extensionVersionInformation)
            : base(extensionVersionInformation)
        {
            if (extensionVersionInformation is not null)
            {
                name = extensionVersionInformation.name;
                informationalVersion = extensionVersionInformation.informationalVersion;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionVersionInformation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public ExtensionVersionInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the extension assembly informational version (e.g., git commit).
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
        /// Gets the simple name of the extension assembly.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }
    }
}
