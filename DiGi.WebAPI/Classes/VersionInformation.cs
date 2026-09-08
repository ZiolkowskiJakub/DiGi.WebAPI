using DiGi.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds multi-tier version and runtime diagnostic information.
    /// <para>The <see cref="Extensions"/> list carries the build stamps of loaded extension assemblies on the public tier; their commit hashes are trimmed unless the caller is authorized.</para>
    /// </summary>
    public class VersionInformation : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(FrameworkDescription))]
        private readonly string? frameworkDescription;

        [JsonInclude, JsonPropertyName(nameof(RuntimeVersion))]
        private readonly string? runtimeVersion;

        [JsonInclude, JsonPropertyName(nameof(ServiceInformationalVersion))]
        private readonly string? serviceInformationalVersion;

        [JsonInclude, JsonPropertyName(nameof(ServiceVersion))]
        private readonly string? serviceVersion;

        [JsonInclude, JsonPropertyName(nameof(StartTimeUtc))]
        private readonly DateTime? startTimeUtc;

        [JsonInclude, JsonPropertyName(nameof(Extensions))]
        private readonly IList<ExtensionVersionInformation>? extensions;

        [JsonInclude, JsonPropertyName(nameof(WebAPIInformationalVersion))]
        private readonly string? webAPIInformationalVersion;

        [JsonInclude, JsonPropertyName(nameof(WebAPIVersion))]
        private readonly string? webAPIVersion;

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInformation"/> class.
        /// </summary>
        /// <param name="serviceVersion">The host service assembly version.</param>
        /// <param name="serviceInformationalVersion">The host service informational version (e.g., git commit).</param>
        /// <param name="webAPIVersion">The WebAPI framework assembly version.</param>
        /// <param name="webAPIInformationalVersion">The WebAPI framework informational version.</param>
        /// <param name="runtimeVersion">The .NET runtime version.</param>
        /// <param name="frameworkDescription">The platform/framework description.</param>
        /// <param name="startTimeUtc">The process start time in UTC.</param>
        /// <param name="extensions">The loaded extension assemblies with their build stamps.</param>
        public VersionInformation(string? serviceVersion, string? serviceInformationalVersion, string? webAPIVersion, string? webAPIInformationalVersion, string? runtimeVersion, string? frameworkDescription, DateTime? startTimeUtc, IEnumerable<ExtensionVersionInformation>? extensions = null)
            : base()
        {
            this.serviceVersion = serviceVersion;
            this.serviceInformationalVersion = serviceInformationalVersion;
            this.webAPIVersion = webAPIVersion;
            this.webAPIInformationalVersion = webAPIInformationalVersion;
            this.runtimeVersion = runtimeVersion;
            this.frameworkDescription = frameworkDescription;
            this.startTimeUtc = startTimeUtc;
            this.extensions = extensions == null ? null : new List<ExtensionVersionInformation>(extensions);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInformation"/> class by copying from another instance.
        /// </summary>
        /// <param name="versionInformation">The <see cref="VersionInformation"/> to copy from.</param>
        public VersionInformation(VersionInformation? versionInformation)
            : base(versionInformation)
        {
            if (versionInformation is not null)
            {
                serviceVersion = versionInformation.serviceVersion;
                serviceInformationalVersion = versionInformation.serviceInformationalVersion;
                webAPIVersion = versionInformation.webAPIVersion;
                webAPIInformationalVersion = versionInformation.webAPIInformationalVersion;
                runtimeVersion = versionInformation.runtimeVersion;
                frameworkDescription = versionInformation.frameworkDescription;
                startTimeUtc = versionInformation.startTimeUtc;

                if (versionInformation.extensions != null)
                {
                    extensions = [];
                    foreach (ExtensionVersionInformation extensionVersionInformation in versionInformation.extensions)
                    {
                        if (Core.Query.Clone(extensionVersionInformation) is ExtensionVersionInformation extensionVersionInformation_Temp)
                        {
                            extensions.Add(extensionVersionInformation_Temp);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInformation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public VersionInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the runtime platform and framework description.
        /// </summary>
        [JsonIgnore]
        public string? FrameworkDescription
        {
            get
            {
                return frameworkDescription;
            }
        }

        /// <summary>
        /// Gets the .NET runtime version.
        /// </summary>
        [JsonIgnore]
        public string? RuntimeVersion
        {
            get
            {
                return runtimeVersion;
            }
        }

        /// <summary>
        /// Gets the host service informational version (e.g., git commit).
        /// </summary>
        [JsonIgnore]
        public string? ServiceInformationalVersion
        {
            get
            {
                return serviceInformationalVersion;
            }
        }

        /// <summary>
        /// Gets the host service assembly version.
        /// </summary>
        [JsonIgnore]
        public string? ServiceVersion
        {
            get
            {
                return serviceVersion;
            }
        }

        /// <summary>
        /// Gets the loaded extension assemblies with their build stamps.
        /// </summary>
        [JsonIgnore]
        public IEnumerable<ExtensionVersionInformation>? Extensions
        {
            get
            {
                return extensions;
            }
        }

        /// <summary>
        /// Gets the host process start time in UTC.
        /// </summary>
        [JsonIgnore]
        public DateTime? StartTimeUtc
        {
            get
            {
                return startTimeUtc;
            }
        }

        /// <summary>
        /// Gets the WebAPI framework informational version.
        /// </summary>
        [JsonIgnore]
        public string? WebAPIInformationalVersion
        {
            get
            {
                return webAPIInformationalVersion;
            }
        }

        /// <summary>
        /// Gets the WebAPI framework assembly version.
        /// </summary>
        [JsonIgnore]
        public string? WebAPIVersion
        {
            get
            {
                return webAPIVersion;
            }
        }
    }
}
