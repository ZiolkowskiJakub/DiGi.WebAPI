using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace DiGi.WebAPI.Classes
{
    public class UrlBuilder
    {
        private readonly Dictionary<string, string> dictionary = [];
        private readonly string url;
        public UrlBuilder(string url)
        {
            this.url = url;
        }

        public IEnumerable<string> ParameterNames
        {
            get
            {
                return dictionary.Keys;
            }
        }

        /// <summary>
        /// Adds a query parameter with automatic URL encoding.
        /// </summary>
        public UrlBuilder AddParameter(string name, string? value)
        {
            if(name is null)
            {
                return this;
            }

            if (value != null)
            {
                // WebUtility.UrlEncode handles special characters like / # & ?
                dictionary[name] = WebUtility.UrlEncode(value);
            }

            return this;
        }

        public UrlBuilder AddParameter(string name, int value)
        {
            return AddParameter(name, value.ToString());
        }

        public UrlBuilder AddParameter(string name, double value)
        {
            return AddParameter(name, value.ToString());
        }

        public UrlBuilder AddParameter(string name, bool value)
        {
            return AddParameter(name, value.ToString());
        }
        /// <summary>
        /// Builds the final URL string.
        /// </summary>
        public string Build()
        {
            if (dictionary.Count == 0)
            {
                return url;
            }

            string parametersString = string.Join("&", dictionary.Select(p => $"{p.Key}={p.Value}"));

            return $"{url}?{parametersString}";
        }

        public override string ToString() => Build();

        public bool TryGetValue<T>(string parameterName, out T? value)
        {
            value = default;

            if(parameterName is null)
            {
                return false;
            }

            if(!dictionary.TryGetValue(parameterName, out string? @string))
            {
                return false;
            }

            @string = WebUtility.UrlDecode(@string);

            if(!Core.Query.TryConvert(@string, out value))
            {
                return false;
            }

            return true;
        }
    }
}
