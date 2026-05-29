using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Provides a fluent API for constructing URLs with query parameters and automatic encoding.
    /// </summary>
    public class UrlBuilder
    {
        /// <summary>
        /// Stores the query parameters to be appended to the URL.
        /// </summary>
        private readonly Dictionary<string, string> dictionary = [];
        /// <summary>
        /// The base URL before query parameters are added.
        /// </summary>
        private readonly string url;

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlBuilder"/> class with the specified base URL.
        /// </summary>
        /// <param name="url">The base URL to build upon.</param>
        public UrlBuilder(string url)
        {
            this.url = url;
        }

        /// <summary>
        /// Gets the names of all query parameters currently added to the URL.
        /// </summary>
        public IEnumerable<string> ParameterNames
        {
            get
            {
                return dictionary.Keys;
            }
        }

        /// <summary>
        /// Converts the <see cref="UrlBuilder"/> to its string representation.
        /// </summary>
        /// <param name="urlBuilder">The <see cref="UrlBuilder"/> instance to convert.</param>
        /// <returns>The built URL string, or null if the builder is null.</returns>
        public static implicit operator string?(UrlBuilder? urlBuilder)
        {
            if (urlBuilder is null)
            {
                return null;
            }

            return urlBuilder.ToString();
        }

        /// <summary>
        /// Adds a query parameter with automatic URL encoding.
        /// </summary>
        public UrlBuilder AddParameter(string name, string? value)
        {
            if (name is null)
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

        /// <summary>
        /// Adds an integer query parameter with automatic URL encoding.
        /// </summary>
        /// <param name="name">The parameter name.</param>
        /// <param name="value">The integer value to encode.</param>
        /// <returns>The <see cref="UrlBuilder"/> instance for chaining.</returns>
        public UrlBuilder AddParameter(string name, int value)
        {
            return AddParameter(name, value.ToString());
        }

        /// <summary>
        /// Adds a double query parameter with automatic URL encoding.
        /// </summary>
        /// <param name="name">The parameter name.</param>
        /// <param name="value">The double value to encode.</param>
        /// <returns>The <see cref="UrlBuilder"/> instance for chaining.</returns>
        public UrlBuilder AddParameter(string name, double value)
        {
            return AddParameter(name, value.ToString());
        }

        /// <summary>
        /// Adds a boolean query parameter with automatic URL encoding.
        /// </summary>
        /// <param name="name">The parameter name.</param>
        /// <param name="value">The boolean value to encode.</param>
        /// <returns>The <see cref="UrlBuilder"/> instance for chaining.</returns>
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

        /// <summary>
        /// Returns the built URL as a string.
        /// </summary>
        /// <returns>The complete URL with query parameters.</returns>
        public override string ToString() => Build();

        /// <summary>
        /// Attempts to retrieve and convert a query parameter value to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to convert the parameter value to.</typeparam>
        /// <param name="parameterName">The name of the query parameter to retrieve.</param>
        /// <param name="value">When this method returns, contains the converted value if found, or default(T) if not found.</param>
        /// <returns>true if the parameter exists and was successfully converted; otherwise, false.</returns>
        public bool TryGetValue<T>(string parameterName, out T? value)
        {
            value = default;

            if (parameterName is null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(parameterName, out string? @string))
            {
                return false;
            }

            @string = WebUtility.UrlDecode(@string);

            if (!Core.Query.TryConvert(@string, out value))
            {
                return false;
            }

            return true;
        }
    }
}