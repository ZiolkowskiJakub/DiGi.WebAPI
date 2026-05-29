using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Manages a collection of <see cref="SecurityKey"/> instances, including generation, retrieval, and removal of keys.
    /// </summary>
    public sealed class SecurityKeyManager : Core.Classes.SerializableObject
    {
        /// <summary>
        /// Stores the security keys indexed by their GUID.
        /// </summary>
        [JsonIgnore]
        private Dictionary<Guid, SecurityKey> securityKeys = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityKeyManager"/> class.
        /// </summary>
        public SecurityKeyManager()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityKeyManager"/> class by copying from another instance.
        /// </summary>
        /// <param name="securityKeyManager">The <see cref="SecurityKeyManager"/> to copy from.</param>
        public SecurityKeyManager(SecurityKeyManager securityKeyManager)
            : base(securityKeyManager)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityKeyManager"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public SecurityKeyManager(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the collection of security keys.
        /// </summary>
        [JsonInclude, JsonPropertyName("SecurityKeys")]
        public IEnumerable<SecurityKey> SecurityKeys
        {
            get
            {
                return [.. securityKeys.Values];
            }

            set
            {
                securityKeys.Clear();

                if (value is null)
                {
                    return;
                }

                foreach (SecurityKey securityKey in value)
                {
                    Add(securityKey);
                }
            }
        }

        /// <summary>
        /// Adds a <see cref="SecurityKey"/> to the manager.
        /// </summary>
        /// <param name="securityKey">The security key to add.</param>
        /// <returns>true if the key was added successfully; otherwise, false.</returns>
        public bool Add(SecurityKey? securityKey)
        {
            if (securityKey is null)
            {
                return false;
            }

            securityKeys[securityKey.Guid] = securityKey;
            return true;
        }

        /// <summary>
        /// Generates a new unique <see cref="SecurityKey"/> and adds it to the manager.
        /// </summary>
        /// <returns>The newly generated <see cref="SecurityKey"/>.</returns>
        public SecurityKey Generate()
        {
            SecurityKey securityKey = new();
            while (securityKeys.ContainsKey(securityKey.Guid))
            {
                securityKey = new();
            }

            securityKeys[securityKey.Guid] = securityKey;

            return securityKey;
        }

        /// <summary>
        /// Gets the most recently created active security key.
        /// </summary>
        /// <param name="generate">Whether to generate a new key if none exist.</param>
        /// <returns>The most recent <see cref="SecurityKey"/>, or null if no keys exist and generate is false.</returns>
        public SecurityKey? GetActive(bool generate = true)
        {
            if (securityKeys.Count == 0)
            {
                if (!generate)
                {
                    return null;
                }

                return Generate();
            }

            SecurityKey? result = null;
            DateTime dateTime = DateTime.MinValue;
            foreach (SecurityKey securityKey in securityKeys.Values)
            {
                if (securityKey.CreatedAt > dateTime)
                {
                    dateTime = securityKey.CreatedAt;
                    result = securityKey;
                }
            }

            return result;
        }

        /// <summary>
        /// Removes a security key by its GUID.
        /// </summary>
        /// <param name="guid">The GUID of the security key to remove.</param>
        /// <returns>true if the key was found and removed; otherwise, false.</returns>
        public bool Remove(Guid guid)
        {
            return securityKeys.Remove(guid);
        }
    }
}