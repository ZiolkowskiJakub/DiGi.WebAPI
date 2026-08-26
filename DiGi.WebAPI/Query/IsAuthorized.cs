using DiGi.WebAPI.Classes;
using System.Security.Cryptography;
using System.Text;

namespace DiGi.WebAPI
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether a provided access key is authorized according to the diagnostics configuration.
        /// <para>Denies by default: a missing configuration, disabled enforcement, a blank configured key or a blank supplied key all deny access. The only way to reach a protected endpoint without a key is the explicit <see cref="DiagnosticsConfiguration.Open"/> opt-out.</para>
        /// </summary>
        /// <param name="diagnosticsConfiguration">The diagnostics configuration to validate against.</param>
        /// <param name="key">The access key to validate.</param>
        /// <returns>True if access is authorized; otherwise, false.</returns>
        public static bool IsAuthorized(this DiagnosticsConfiguration? diagnosticsConfiguration, string? key)
        {
            if (diagnosticsConfiguration is null)
            {
                return false;
            }

            if (diagnosticsConfiguration.Open)
            {
                return true;
            }

            if (!diagnosticsConfiguration.Enabled)
            {
                return false;
            }

            string? key_Configured = diagnosticsConfiguration.Key;

            if (string.IsNullOrWhiteSpace(key_Configured) || string.IsNullOrWhiteSpace(key))
            {
                return false;
            }

            byte[] bytes_Configured = Encoding.UTF8.GetBytes(key_Configured);
            byte[] bytes_Provided = Encoding.UTF8.GetBytes(key);

            return CryptographicOperations.FixedTimeEquals(bytes_Configured, bytes_Provided);
        }
    }
}
