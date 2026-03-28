using DiGi.Core.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    public class PostOptions : SerializableOptions
    {
        public PostOptions()
        {
        }

        public PostOptions(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public PostOptions(PostOptions? postOptions)
            : base(postOptions)
        {
            if (postOptions is not null)
            {
                Delay = postOptions.Delay;
                RequestResult = postOptions.RequestResult;
            }
        }

        [JsonInclude, JsonPropertyName("Delay")]
        public TimeSpan Delay { get; set; } = TimeSpan.FromSeconds(20);

        [JsonInclude, JsonPropertyName("RequestResult")]
        public bool RequestResult { get; set; } = true;
    }
}