using DiGi.WebAPI.Classes;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.WebAPI
{
    public static partial class Modify
    {
        public static async Task<PostResponse> PostAsync(this HttpClient httpClient, string? requestUri, HttpContent? httpContent, PostOptions? postOptions = null)
        {
            PostOptions postOptions_Temp = postOptions is null ? new PostOptions() : new PostOptions(postOptions);
            postOptions_Temp.RequestResult = false;

            PostResponse<bool> postResponse = await PostAsync(httpClient, requestUri, httpContent, postOptions_Temp);

            return new PostResponse(postResponse.Succeeded);
        }

        public static async Task<PostResponse<T?>> PostAsync<T>(this HttpClient httpClient, string? requestUri, HttpContent? httpContent, PostOptions? postOptions = null)
        {
            if (httpClient is null || string.IsNullOrWhiteSpace(requestUri))
            {
                return new PostResponse<T?>(false);
            }

            postOptions ??= new PostOptions();

            using CancellationTokenSource cancellationTokenSource = new(postOptions.Delay);

            try
            {
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(requestUri, httpContent, cancellationTokenSource.Token).ConfigureAwait(false);

                using (httpResponseMessage)
                {
                    if (!httpResponseMessage.IsSuccessStatusCode)
                    {
                        string errorContent = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                        Exception exception = new($"Server returned {httpResponseMessage.StatusCode}. Details: {errorContent}");

                        throw exception;
                    }

                    bool resultRequested = postOptions.RequestResult;

                    if (!resultRequested)
                    {
                        return new PostResponse<T?>(true, resultRequested);
                    }

                    if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.NoContent || httpResponseMessage.Content.Headers.ContentLength == 0)
                    {
                        return new PostResponse<T?>(true, resultRequested);
                    }

                    return await Create.PostResponse<T>(httpResponseMessage.Content);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}