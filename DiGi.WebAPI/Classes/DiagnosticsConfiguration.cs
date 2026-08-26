using DiGi.WebAPI.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds configuration settings for protecting diagnostic endpoints via API key authorization.
    /// <para>Access is denied by default. A protected endpoint is reachable only when <see cref="Enabled"/> is true and the supplied key matches <see cref="Key"/>, or when <see cref="Open"/> explicitly waives the check.</para>
    /// </summary>
    public class DiagnosticsConfiguration : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Enabled))]
        private readonly bool enabled;

        [JsonInclude, JsonPropertyName(nameof(Key))]
        private readonly string? key;

        [JsonInclude, JsonPropertyName(nameof(Open))]
        private readonly bool open;

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsConfiguration"/> class.
        /// <para>The parameterless form denies every protected request, which is the intended default for an unconfigured host.</para>
        /// </summary>
        /// <param name="key">The secret diagnostic access token.</param>
        /// <param name="enabled">Whether authorization enforcement is enabled.</param>
        /// <param name="open">Whether the key check is explicitly waived, leaving protected endpoints unauthenticated.</param>
        public DiagnosticsConfiguration(string? key = null, bool enabled = false, bool open = false)
            : base()
        {
            this.key = key;
            this.enabled = enabled;
            this.open = open;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsConfiguration"/> class by copying from another instance.
        /// </summary>
        /// <param name="diagnosticsConfiguration">The <see cref="DiagnosticsConfiguration"/> to copy from.</param>
        public DiagnosticsConfiguration(DiagnosticsConfiguration? diagnosticsConfiguration)
            : base(diagnosticsConfiguration)
        {
            if (diagnosticsConfiguration is not null)
            {
                key = diagnosticsConfiguration.key;
                enabled = diagnosticsConfiguration.enabled;
                open = diagnosticsConfiguration.open;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsConfiguration"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public DiagnosticsConfiguration(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets a value indicating whether diagnostic authorization enforcement is enabled.
        /// <para>False denies every protected request; it does not open them.</para>
        /// </summary>
        [JsonIgnore]
        public bool Enabled
        {
            get
            {
                return enabled;
            }
        }

        /// <summary>
        /// Gets the secret diagnostic access token.
        /// </summary>
        [JsonIgnore]
        public string? Key
        {
            get
            {
                return key;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the key check is explicitly waived, leaving protected diagnostic endpoints reachable without a key.
        /// <para>Intended for local development only. This is the sole setting that grants unauthenticated access to the protected tier.</para>
        /// </summary>
        [JsonIgnore]
        public bool Open
        {
            get
            {
                return open;
            }
        }
    }
}
