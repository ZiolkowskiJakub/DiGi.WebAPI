using DiGi.WebAPI.Classes;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.WebAPI
{
    public static partial class Modify
    {
        /// <summary>
        /// Performs an HTTP POST operation without requesting the response result.
        /// </summary>
        /// <param name="httpClient">The HTTP client to use for the request.</param>
        /// <param name="requestUri">The URI to send the request to.</param>
        /// <param name="httpContent">The HTTP content to send in the request body.</param>
        /// <param name="postOptions">Optional configuration options for the POST operation.</param>
        /// <returns>A <see cref="PostResponse"/> indicating the success or failure of the operation.</returns>
        public static async Task<PostResponse> PostAsync(this HttpClient httpClient, string? requestUri, HttpContent? httpContent, PostOptions? postOptions = null)
        {
            PostOptions postOptions_Temp = postOptions is null ? new PostOptions() : new PostOptions(postOptions);
            postOptions_Temp.RequestResult = false;

            Serilog.Modify.Log("Result not requested");

            PostResponse<bool> postResponse = await PostAsync<bool>(httpClient, requestUri, httpContent, postOptions_Temp);

            return new PostResponse(postResponse.Succeeded);
        }

        /// <summary>
        /// Performs an HTTP POST operation and deserializes the response into the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the response result.</typeparam>
        /// <param name="httpClient">The HTTP client to use for the request.</param>
        /// <param name="requestUri">The URI to send the request to.</param>
        /// <param name="httpContent">The HTTP content to send in the request body.</param>
        /// <param name="postOptions">Optional configuration options for the POST operation.</param>
        /// <returns>A <see cref="PostResponse{T}"/> containing the deserialized result or failure information.</returns>
        public static async Task<PostResponse<T?>> PostAsync<T>(this HttpClient httpClient, string? requestUri, HttpContent? httpContent, PostOptions? postOptions = null)
        {
            if (httpClient is null || string.IsNullOrWhiteSpace(requestUri))
            {
                return new PostResponse<T?>(false);
            }

            postOptions ??= new PostOptions();

            Serilog.Modify.Log("Setting delay : {Delay}s", postOptions.Delay.Seconds);

            using CancellationTokenSource cancellationTokenSource = new(postOptions.Delay);

            try
            {
                Serilog.Modify.Log("PostAsync started - URL: {URL}", requestUri ?? string.Empty);

                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(requestUri, httpContent, cancellationTokenSource.Token).ConfigureAwait(false);

                Serilog.Modify.Log("PostAsync ended", requestUri ?? string.Empty);

                if(httpResponseMessage is null)
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
            catch
            {
                throw;
            }
        }
    }
}