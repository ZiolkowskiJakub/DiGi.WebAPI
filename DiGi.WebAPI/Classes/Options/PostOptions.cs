using DiGi.Core.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds configuration options for POST operations, including delay and result request settings.
    /// </summary>
    public class PostOptions : SerializableOptions
    {
        [JsonInclude, JsonPropertyName(nameof(Delay))]
        private TimeSpan delay = TimeSpan.FromSeconds(20);

        [JsonInclude, JsonPropertyName(nameof(RequestResult))]
        private bool requestResult = true;

        [JsonInclude, JsonPropertyName(nameof(RetryCount))]
        private int retryCount = 3;

        [JsonInclude, JsonPropertyName(nameof(RetryDelay))]
        private TimeSpan retryDelay = TimeSpan.FromSeconds(2);

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOptions"/> class.
        /// </summary>
        public PostOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOptions"/> class by copying from another instance.
        /// </summary>
        /// <param name="postOptions">The <see cref="PostOptions"/> to copy from.</param>
        public PostOptions(PostOptions? postOptions)
            : base(postOptions)
        {
            if (postOptions is not null)
            {
                delay = postOptions.delay;
                requestResult = postOptions.requestResult;
                retryCount = postOptions.retryCount;
                retryDelay = postOptions.retryDelay;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOptions"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public PostOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the delay duration for the POST operation.
        /// <para>This bounds a single attempt, not the whole operation - a retried request gets the full delay again.</para>
        /// </summary>
        [JsonIgnore]
        public TimeSpan Delay
        {
            get
            {
                return delay;
            }
            set
            {
                delay = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the response result should be requested.
        /// </summary>
        [JsonIgnore]
        public bool RequestResult
        {
            get
            {
                return requestResult;
            }
            set
            {
                requestResult = value;
            }
        }

        /// <summary>
        /// Gets or sets how many additional attempts are made after a transient failure. Zero disables retrying.
        /// <para>Only transient conditions are retried - see <see cref="Query.IsTransient(System.Net.HttpStatusCode)"/>. A response that indicates a genuine fault, such as 400 or 500, fails on the first attempt.</para>
        /// </summary>
        [JsonIgnore]
        public int RetryCount
        {
            get
            {
                return retryCount;
            }
            set
            {
                retryCount = value;
            }
        }

        /// <summary>
        /// Gets or sets the wait before the first retry. The wait doubles after each further attempt.
        /// </summary>
        [JsonIgnore]
        public TimeSpan RetryDelay
        {
            get
            {
                return retryDelay;
            }
            set
            {
                retryDelay = value;
            }
        }
    }
}