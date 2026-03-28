using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    public sealed class SecurityKeyManager : Core.Classes.SerializableObject
    {
        [JsonIgnore]
        private Dictionary<Guid, SecurityKey> securityKeys = [];

        public SecurityKeyManager()
        {
        }

        public SecurityKeyManager(SecurityKeyManager securityKeyManager)
            : base(securityKeyManager)
        {
        }

        public SecurityKeyManager(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

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

        public bool Add(SecurityKey? securityKey)
        {
            if (securityKey is null)
            {
                return false;
            }

            securityKeys[securityKey.Guid] = securityKey;
            return true;
        }

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

        public bool Remove(Guid guid)
        {
            return securityKeys.Remove(guid);
        }
    }
}