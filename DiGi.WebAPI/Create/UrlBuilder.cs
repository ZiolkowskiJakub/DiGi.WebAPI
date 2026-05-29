using DiGi.WebAPI.Classes;
using System.Net;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Parses a URL string and creates a <see cref="UrlBuilder"/> with the base URL and query parameters.
        /// </summary>
        /// <param name="url">The URL string to parse.</param>
        /// <returns>A <see cref="UrlBuilder"/> instance, or null if the URL is null or whitespace.</returns>
        public static UrlBuilder? UrlBuilder(this string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return null;
            }

            string[] parts = url.Split('?');

            string baseUrl = parts[0];

            UrlBuilder builder = new(baseUrl);

            if (parts.Length > 1)
            {
                string query = parts[1];
                string[] pairs = query.Split('&');

                foreach (string pair in pairs)
                {
                    string[] kvp = pair.Split('=');
                    if (kvp.Length == 2)
                    {
                        string key = kvp[0];
                        // Decodes %2F to /, %23 to #, etc.
                        string value = WebUtility.UrlDecode(kvp[1]);
                        builder.AddParameter(key, value);
                    }
                }
            }

            return builder;
        }
    }
}