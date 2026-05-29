using DiGi.WebAPI.Interfaces;
using System;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Represents a security key with a unique identifier and creation timestamp.
    /// </summary>
    public sealed class SecurityKey : Core.Classes.GuidObject, IWebAPIGuidObject
    {
        /// <summary>
        /// Gets the key value as a string.
        /// </summary>
        [JsonInclude, JsonPropertyName("Key")]
        public string Key { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the UTC date and time when the key was created.
        /// </summary>
        [JsonInclude, JsonPropertyName("CreatedAt")]
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityKey"/> class with a randomly generated key.
        /// </summary>
        public SecurityKey()
        {
            Key = Guid.NewGuid().ToString("N");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityKey"/> class with the specified key value.
        /// </summary>
        /// <param name="key">The key value to use.</param>
        public SecurityKey(string? key)
            : this()
        {
            if (key != null)
            {
                Key = key;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityKey"/> class by copying from another instance.
        /// </summary>
        /// <param name="securityKey">The <see cref="SecurityKey"/> to copy from.</param>
        public SecurityKey(SecurityKey? securityKey)
            : base(securityKey)
        {
            if (securityKey != null)
            {
                Key = securityKey.Key;
                CreatedAt = securityKey.CreatedAt;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityKey"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public SecurityKey(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Converts the key to a byte array using ASCII encoding.
        /// </summary>
        /// <returns>A byte array representation of the key.</returns>
        public byte[] GetBytes()
        {
            return Encoding.ASCII.GetBytes(Key);
        }
    }
}