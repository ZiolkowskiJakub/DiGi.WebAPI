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
        /// <para>A name maps to a list rather than a single value because a query string may repeat a name, which is how ASP.NET Core binds a collection parameter. The single-value overloads still hold one value per name and replace what was there.</para>
        /// </summary>
        private readonly Dictionary<string, List<string>> dictionary = [];
        
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
        /// <param name="name">The name of the query parameter.</param>
        /// <param name="value">The value of the query parameter.</param>
        /// <returns>The current UrlBuilder instance.</returns>
        public UrlBuilder AddParameter(string name, string? value)
        {
            if (name is null)
            {
                return this;
            }

            if (value != null)
            {
                // WebUtility.UrlEncode handles special characters like / # & ?
                dictionary[name] = [WebUtility.UrlEncode(value)];
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
        /// Adds an integer query parameter once per value, so the name repeats in the query string.
        /// <para>This is how a collection reaches a <c>[FromQuery]</c> action parameter: ASP.NET Core binds <c>?name=1&amp;name=2</c> to an <c>int[]</c>, and does not split a single comma-separated value into one. Passing no values adds nothing rather than an empty parameter, and <see cref="TryGetValue{T}(string, out T)"/> reads back only the first of them.</para>
        /// </summary>
        /// <param name="name">The parameter name.</param>
        /// <param name="values">The integer values to encode, one occurrence of the parameter each.</param>
        /// <returns>The <see cref="UrlBuilder"/> instance for chaining.</returns>
        public UrlBuilder AddParameter(string name, IEnumerable<int>? values)
        {
            if (name is null || values is null)
            {
                return this;
            }

            List<string> strings = [.. values.Select(x => WebUtility.UrlEncode(x.ToString()))];
            if (strings.Count == 0)
            {
                return this;
            }

            dictionary[name] = strings;

            return this;
        }

        /// <summary>
        /// Builds the final URL string.
        /// </summary>
        /// <returns>The built URL string with query parameters.</returns>
        public string Build()
        {
            if (dictionary.Count == 0)
            {
                return url;
            }

            string parametersString = string.Join("&", dictionary.SelectMany(p => p.Value.Select(x => $"{p.Key}={x}")));

            return $"{url}?{parametersString}";
        }

        /// <summary>
        /// Returns the built URL as a string.
        /// </summary>
        /// <returns>The complete URL with query parameters.</returns>
        public override string ToString() => Build();

        /// <summary>
        /// Attempts to retrieve and convert a query parameter value to the specified type.
        /// <para>A name added through <see cref="AddParameter(string, IEnumerable{int})"/> holds several values; the first is the one returned.</para>
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

            if (!dictionary.TryGetValue(parameterName, out List<string>? strings) || strings is null || strings.Count == 0)
            {
                return false;
            }

            string? @string = WebUtility.UrlDecode(strings[0]);

            if (!Core.Query.TryConvert(@string, out value))
            {
                return false;
            }

            return true;
        }
    }
}
