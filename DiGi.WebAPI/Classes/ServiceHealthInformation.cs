using DiGi.WebAPI.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds service health and liveness status information.
    /// </summary>
    public class ServiceHealthInformation : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(ProcessId))]
        private readonly int processId;

        [JsonInclude, JsonPropertyName(nameof(ServerTimeLocal))]
        private readonly DateTimeOffset serverTimeLocal;

        [JsonInclude, JsonPropertyName(nameof(ServerTimeUtc))]
        private readonly DateTime serverTimeUtc;

        [JsonInclude, JsonPropertyName(nameof(Status))]
        private readonly string? status;

        [JsonInclude, JsonPropertyName(nameof(Uptime))]
        private readonly TimeSpan uptime;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceHealthInformation"/> class.
        /// </summary>
        /// <param name="status">The health status description (e.g., "Healthy").</param>
        /// <param name="serverTimeUtc">The server current time in UTC.</param>
        /// <param name="serverTimeLocal">The server current local time with offset.</param>
        /// <param name="uptime">The elapsed process uptime.</param>
        /// <param name="processId">The host process identifier.</param>
        public ServiceHealthInformation(string? status, DateTime serverTimeUtc, DateTimeOffset serverTimeLocal, TimeSpan uptime, int processId)
            : base()
        {
            this.status = status;
            this.serverTimeUtc = serverTimeUtc;
            this.serverTimeLocal = serverTimeLocal;
            this.uptime = uptime;
            this.processId = processId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceHealthInformation"/> class by copying from another instance.
        /// </summary>
        /// <param name="serviceHealthInformation">The <see cref="ServiceHealthInformation"/> to copy from.</param>
        public ServiceHealthInformation(ServiceHealthInformation? serviceHealthInformation)
            : base(serviceHealthInformation)
        {
            if (serviceHealthInformation is not null)
            {
                status = serviceHealthInformation.status;
                serverTimeUtc = serviceHealthInformation.serverTimeUtc;
                serverTimeLocal = serviceHealthInformation.serverTimeLocal;
                uptime = serviceHealthInformation.uptime;
                processId = serviceHealthInformation.processId;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceHealthInformation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public ServiceHealthInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the host process identifier.
        /// </summary>
        [JsonIgnore]
        public int ProcessId
        {
            get
            {
                return processId;
            }
        }

        /// <summary>
        /// Gets the server current local time with offset.
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset ServerTimeLocal
        {
            get
            {
                return serverTimeLocal;
            }
        }

        /// <summary>
        /// Gets the server current time in UTC.
        /// </summary>
        [JsonIgnore]
        public DateTime ServerTimeUtc
        {
            get
            {
                return serverTimeUtc;
            }
        }

        /// <summary>
        /// Gets the health status description (e.g., "Healthy").
        /// </summary>
        [JsonIgnore]
        public string? Status
        {
            get
            {
                return status;
            }
        }

        /// <summary>
        /// Gets the elapsed process uptime.
        /// </summary>
        [JsonIgnore]
        public TimeSpan Uptime
        {
            get
            {
                return uptime;
            }
        }
    }
}
