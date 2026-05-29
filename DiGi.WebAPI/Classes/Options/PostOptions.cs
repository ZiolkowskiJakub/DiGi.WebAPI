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
        /// <summary>
        /// Initializes a new instance of the <see cref="PostOptions"/> class.
        /// </summary>
        public PostOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOptions"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public PostOptions(JsonObject jsonObject)
            : base(jsonObject)
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
                Delay = postOptions.Delay;
                RequestResult = postOptions.RequestResult;
            }
        }

        /// <summary>
        /// Gets or sets the delay duration for the POST operation.
        /// </summary>
        [JsonInclude, JsonPropertyName("Delay")]
        public TimeSpan Delay { get; set; } = TimeSpan.FromSeconds(20);

        /// <summary>
        /// Gets or sets a value indicating whether the response result should be requested.
        /// </summary>
        [JsonInclude, JsonPropertyName("RequestResult")]
        public bool RequestResult { get; set; } = true;
    }
}