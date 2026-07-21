using DiGi.WebAPI.Classes;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.WebAPI
{
    public static partial class Query
    {
        /// <summary>
        /// Performs an HTTP GET operation and deserializes the response into the specified type.
        /// <para><see cref="PostOptions"/> and <see cref="PostResponse{T}"/> are shared by the GET and POST helpers - <see cref="PostOptions.Delay"/> bounds the request and <see cref="PostOptions.RequestResult"/> controls whether the response body is materialised.</para>
        /// </summary>
        /// <typeparam name="T">The type of the response result.</typeparam>
        /// <param name="httpClient">The HTTP client to use for the request.</param>
        /// <param name="requestUri">The URI to send the request to.</param>
        /// <param name="postOptions">Optional configuration options for the GET operation.</param>
        /// <returns>A <see cref="PostResponse{T}"/> containing the deserialized result or failure information.</returns>
        public static async Task<PostResponse<T?>> GetAsync<T>(this HttpClient? httpClient, string? requestUri, PostOptions? postOptions = null)
        {
            if (httpClient is null || string.IsNullOrWhiteSpace(requestUri))
            {
                return new PostResponse<T?>(false);
            }

            postOptions ??= new PostOptions();

            Serilog.Modify.Log("Setting delay : {Delay}s", postOptions.Delay.Seconds);

            using CancellationTokenSource cancellationTokenSource = new(postOptions.Delay);

            Serilog.Modify.Log("GetAsync started - URL: {URL}", requestUri ?? string.Empty);

            // Binds to the HttpClient instance method - the extension method declared here takes a PostOptions, not a CancellationToken.
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(requestUri, cancellationTokenSource.Token).ConfigureAwait(false);

            Serilog.Modify.Log("GetAsync ended", requestUri ?? string.Empty);

            if (httpResponseMessage is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "HttpResponseMessage is null");

                return new PostResponse<T?>(false);
            }

            using (httpResponseMessage)
            {
                if (!httpResponseMessage.IsSuccessStatusCode)
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "HttpResponseMessage did not return successful code");

                    string errorContent = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Error content: {ErrorContent}", errorContent);

                    Exception exception = new($"Server returned {httpResponseMessage.StatusCode}. Details: {errorContent}");

                    throw exception;
                }

                bool resultRequested = postOptions.RequestResult;

                if (!resultRequested)
                {
                    Serilog.Modify.Log("Result has not been requested");

                    return new PostResponse<T?>(true, resultRequested);
                }

                if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.NoContent || httpResponseMessage.Content.Headers.ContentLength == 0)
                {
                    Serilog.Modify.Log("There is no content in response");

                    return new PostResponse<T?>(true, resultRequested);
                }

                Serilog.Modify.Log("Response content processing started");

                PostResponse<T?> postResponse = await Create.PostResponse<T>(httpResponseMessage.Content);

                Serilog.Modify.Log("Response content processing ended. Succeeded: {Succeeded}", postResponse.Succeeded);

                return postResponse;
            }
        }
    }
}
