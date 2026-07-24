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
        /// Performs an HTTP POST operation without requesting the response result, rebuilding the request body for every attempt.
        /// <para>Prefer this overload whenever retrying matters - see the factory overload of <see cref="PostAsync{T}(HttpClient, string?, Func{Task{HttpContent?}}?, PostOptions?)"/> for why the body cannot be reused.</para>
        /// </summary>
        /// <param name="httpClient">The HTTP client to use for the request.</param>
        /// <param name="requestUri">The URI to send the request to.</param>
        /// <param name="httpContentFactory">Builds the request body. Invoked once per attempt.</param>
        /// <param name="postOptions">Optional configuration options for the POST operation.</param>
        /// <returns>A <see cref="PostResponse"/> indicating the success or failure of the operation.</returns>
        public static async Task<PostResponse> PostAsync(this HttpClient httpClient, string? requestUri, Func<Task<HttpContent?>>? httpContentFactory, PostOptions? postOptions = null)
        {
            PostOptions postOptions_Temp = postOptions is null ? new PostOptions() : new PostOptions(postOptions);
            postOptions_Temp.RequestResult = false;

            Serilog.Modify.Log("Result not requested");

            PostResponse<bool> postResponse = await PostAsync<bool>(httpClient, requestUri, httpContentFactory, postOptions_Temp);

            return new PostResponse(postResponse.Succeeded);
        }

        /// <summary>
        /// Performs an HTTP POST operation and deserializes the response into the specified type.
        /// <para>The supplied <paramref name="httpContent"/> is consumed and disposed by the send, so it cannot be resent. Retrying is therefore disabled for this overload regardless of <see cref="PostOptions.RetryCount"/>; use the factory overload to get retries.</para>
        /// </summary>
        /// <typeparam name="T">The type of the response result.</typeparam>
        /// <param name="httpClient">The HTTP client to use for the request.</param>
        /// <param name="requestUri">The URI to send the request to.</param>
        /// <param name="httpContent">The HTTP content to send in the request body.</param>
        /// <param name="postOptions">Optional configuration options for the POST operation.</param>
        /// <returns>A <see cref="PostResponse{T}"/> containing the deserialized result or failure information.</returns>
        public static async Task<PostResponse<T?>> PostAsync<T>(this HttpClient httpClient, string? requestUri, HttpContent? httpContent, PostOptions? postOptions = null)
        {
            PostOptions postOptions_Temp = postOptions is null ? new PostOptions() : new PostOptions(postOptions);

            // A null body has nothing to consume, so it can be "rebuilt" freely and retrying stays safe.
            if (httpContent is not null && postOptions_Temp.RetryCount > 0)
            {
                Serilog.Modify.Log("Retrying disabled - the request body was supplied as a single-use HttpContent and cannot be resent");
                postOptions_Temp.RetryCount = 0;
            }

            return await PostAsync<T>(httpClient, requestUri, () => Task.FromResult(httpContent), postOptions_Temp);
        }

        /// <summary>
        /// Performs an HTTP POST operation and deserializes the response into the specified type, retrying transient failures.
        /// <para>The body is built by <paramref name="httpContentFactory"/> once per attempt. A factory is required rather than an <see cref="HttpContent"/> instance because sending consumes and disposes the content - a retry that reused it would post an empty body.</para>
        /// <para>Only transient responses are retried (see <see cref="Query.IsTransient(System.Net.HttpStatusCode)"/>), with the wait doubling after each attempt. Anything else throws on the first attempt, as does an exhausted retry, so a caller's failure handling is unchanged.</para>
        /// </summary>
        /// <typeparam name="T">The type of the response result.</typeparam>
        /// <param name="httpClient">The HTTP client to use for the request.</param>
        /// <param name="requestUri">The URI to send the request to.</param>
        /// <param name="httpContentFactory">Builds the request body. Invoked once per attempt; may return null for a bodyless POST.</param>
        /// <param name="postOptions">Optional configuration options for the POST operation.</param>
        /// <returns>A <see cref="PostResponse{T}"/> containing the deserialized result or failure information.</returns>
        public static async Task<PostResponse<T?>> PostAsync<T>(this HttpClient httpClient, string? requestUri, Func<Task<HttpContent?>>? httpContentFactory, PostOptions? postOptions = null)
        {
            if (httpClient is null || string.IsNullOrWhiteSpace(requestUri) || httpContentFactory is null)
            {
                return new PostResponse<T?>(false);
            }

            postOptions ??= new PostOptions();

            Serilog.Modify.Log("Setting delay : {Delay}s", postOptions.Delay.TotalSeconds);

            int attemptCount = postOptions.RetryCount < 0 ? 1 : postOptions.RetryCount + 1;
            TimeSpan retryDelay = postOptions.RetryDelay;

            for (int attempt = 1; ; attempt++)
            {
                try
                {
                    return await PostAsync_Attempt(httpClient, requestUri!, httpContentFactory, postOptions);
                }
                catch (TransientPostException transientPostException)
                {
                    if (attempt >= attemptCount)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Attempt {Attempt}/{AttemptCount} failed and no attempts remain", attempt, attemptCount);

                        // Surface the underlying failure, not the internal signal type.
                        throw transientPostException.InnerException ?? transientPostException;
                    }

                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Attempt {Attempt}/{AttemptCount} hit a transient failure; retrying in {Delay}s. Reason: {Reason}", attempt, attemptCount, retryDelay.TotalSeconds, transientPostException.Message);
                }

                await Task.Delay(retryDelay).ConfigureAwait(false);

                if (retryDelay <= TimeSpan.MaxValue / 2)
                {
                    retryDelay = TimeSpan.FromTicks(retryDelay.Ticks * 2);
                }
                else
                {
                    retryDelay = TimeSpan.MaxValue;
                }
            }

            static async Task<PostResponse<T?>> PostAsync_Attempt(HttpClient httpClient, string requestUri, Func<Task<HttpContent?>> httpContentFactory, PostOptions postOptions)
            {
                // A fresh token per attempt - PostOptions.Delay bounds one attempt, not the whole operation.
                using CancellationTokenSource cancellationTokenSource = new(postOptions.Delay);

                HttpContent? httpContent = await httpContentFactory.Invoke().ConfigureAwait(false);

                Serilog.Modify.Log("PostAsync started - URL: {URL}", requestUri);

                HttpResponseMessage httpResponseMessage;

                try
                {
                    httpResponseMessage = await httpClient.PostAsync(requestUri, httpContent, cancellationTokenSource.Token).ConfigureAwait(false);
                }
                catch (HttpRequestException httpRequestException)
                {
                    // The connection itself failed - refused, reset, DNS. Worth another attempt.
                    throw new TransientPostException(httpRequestException.Message, httpRequestException);
                }
                catch (OperationCanceledException operationCanceledException) when (cancellationTokenSource.IsCancellationRequested)
                {
                    // The per-attempt timeout was reached. Worth another attempt.
                    throw new TransientPostException($"Request timed out after {postOptions.Delay.TotalSeconds}s", operationCanceledException);
                }

                Serilog.Modify.Log("PostAsync ended");

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

                        if (httpResponseMessage.StatusCode.IsTransient())
                        {
                            throw new TransientPostException(exception.Message, exception);
                        }

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

    internal class TransientPostException : Exception
    {
        public TransientPostException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
