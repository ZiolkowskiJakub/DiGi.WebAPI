using DiGi.WebAPI.Interfaces;
using System;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    public sealed class SecurityKey : Core.Classes.GuidObject, IWebAPIGuidObject
    {
        [JsonInclude, JsonPropertyName("Key")]
        public string Key { get; private set; } = string.Empty;

        [JsonInclude, JsonPropertyName("CreatedAt")]
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

        public SecurityKey()
        {
            Key = Guid.NewGuid().ToString("N");
        }

        public SecurityKey(string? key)
            : this()
        {
            if(key != null)
            {
                Key = key;
            }
        }

        public SecurityKey(SecurityKey? securityKey)
            :base(securityKey)
        {
            if(securityKey != null)
            {
                Key = securityKey.Key;
                CreatedAt = securityKey.CreatedAt;
            }
        }

        public SecurityKey(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public byte[] GetBytes()
        {
            return Encoding.ASCII.GetBytes(Key);
        }
    }
}
