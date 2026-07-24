using System.Net;

namespace DiGi.WebAPI
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether a response status represents a transient condition that is worth retrying.
        /// <para>Transient means the request may well succeed if sent again unchanged: the gateway lost its upstream (502), the service is unavailable or restarting (503), the gateway timed out waiting (504), the server asked the client to retry (408, 429).</para>
        /// <para>Everything else is treated as a genuine fault and fails on the first attempt. In particular <see cref="HttpStatusCode.InternalServerError"/> is NOT transient - a 500 from a DiGi controller is an unhandled exception it already logged, and retrying only repeats it.</para>
        /// </summary>
        /// <param name="httpStatusCode">The status returned by the server.</param>
        /// <returns>True if the request should be retried; otherwise, false.</returns>
        public static bool IsTransient(this HttpStatusCode httpStatusCode)
        {
            switch (httpStatusCode)
            {
                case HttpStatusCode.BadGateway:
                case HttpStatusCode.ServiceUnavailable:
                case HttpStatusCode.GatewayTimeout:
                case HttpStatusCode.RequestTimeout:
                case (HttpStatusCode)429: // TooManyRequests - not defined in netstandard2.0
                    return true;

                default:
                    return false;
            }
        }
    }
}
