using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stripe.Infrastructure
{
    internal static class Requestor
    {
        internal static HttpClient HttpClient { get; private set; }

        static Requestor()
        {
            HttpClient =
                StripeConfiguration.HttpMessageHandler != null
                    ? new HttpClient(StripeConfiguration.HttpMessageHandler)
                    : new HttpClient();

            if (StripeConfiguration.HttpTimeSpan.HasValue)
                HttpClient.Timeout = StripeConfiguration.HttpTimeSpan.Value;
        }



        // Sync
        public static StripeResponse GetString(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Get, requestOptions);

            return ExecuteRequest(wr);
        }

        public static StripeResponse PostString(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions);

            return ExecuteRequest(wr);
        }

        public static StripeResponse Delete(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Delete, requestOptions);

            return ExecuteRequest(wr);
        }

        public static StripeResponse PostFile(string url, string fileName, Stream fileStream, string purpose, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions);

            ApplyMultiPartFileToRequest(wr, fileName, fileStream, purpose);

            return ExecuteRequest(wr);
        }

        private static StripeResponse ExecuteRequest(HttpRequestMessage requestMessage)
        {
            var response = HttpClient.SendAsync(requestMessage).ConfigureAwait(false).GetAwaiter().GetResult();
            var responseText = response.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();

            var result = BuildResponseData(response, responseText);

            if (response.IsSuccessStatusCode) return result;

            throw BuildStripeException(result, response.StatusCode, requestMessage.RequestUri.AbsoluteUri, responseText);
        }


        // Async
        public static Task<StripeResponse> GetStringAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = GetRequestMessage(url, HttpMethod.Get, requestOptions);

            return ExecuteRequestAsync(wr, cancellationToken);
        }

        public static Task<StripeResponse> PostStringAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions);

            return ExecuteRequestAsync(wr, cancellationToken);
        }

        public static Task<StripeResponse> DeleteAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = GetRequestMessage(url, HttpMethod.Delete, requestOptions);

            return ExecuteRequestAsync(wr, cancellationToken);
        }

        public static Task<StripeResponse> PostFileAsync(string url, string fileName, Stream fileStream, string purpose, StripeRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions);

            ApplyMultiPartFileToRequest(wr, fileName, fileStream, purpose);

            return ExecuteRequestAsync(wr, cancellationToken);
        }

        private static async Task<StripeResponse> ExecuteRequestAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await HttpClient.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            var result = BuildResponseData(response, responseText);

            if (response.IsSuccessStatusCode)
                return result;

            throw BuildStripeException(result, response.StatusCode, requestMessage.RequestUri.AbsoluteUri, responseText);
        }



        private static HttpRequestMessage GetRequestMessage(string url, HttpMethod method, StripeRequestOptions requestOptions)
        {
            requestOptions.ApiKey = requestOptions.ApiKey ?? StripeConfiguration.GetApiKey();

#if NET45
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
#endif

            var request = BuildRequest(method, url);

            request.Headers.Add("Authorization",
                GetAuthorizationHeaderValue(requestOptions.ApiKey));

            if (requestOptions.StripeConnectAccountId != null)
                request.Headers.Add("Stripe-Account", requestOptions.StripeConnectAccountId);

            if (requestOptions.IdempotencyKey != null)
                request.Headers.Add("Idempotency-Key", requestOptions.IdempotencyKey);

            if (requestOptions.StripeVersion != null)
                request.Headers.Add("Stripe-Version", requestOptions.StripeVersion);
            else
                request.Headers.Add("Stripe-Version", StripeConfiguration.StripeApiVersion);

            var client = new Client(request);
            client.ApplyUserAgent();
            client.ApplyClientData();

            return request;
        }

        private static HttpRequestMessage BuildRequest(HttpMethod method, string url)
        {
            if (method != HttpMethod.Post)
                return new HttpRequestMessage(method, new Uri(url));

            var postData = string.Empty;
            var newUrl = url;

            if (!string.IsNullOrEmpty(new Uri(url).Query))
            {
                postData = new Uri(url).Query.Substring(1);
                newUrl = url.Substring(0, url.IndexOf("?", StringComparison.CurrentCultureIgnoreCase));
            }

            var request = new HttpRequestMessage(method, new Uri(newUrl))
            {
                Content = new StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded")
            };

            return request;
        }

        private static string GetAuthorizationHeaderValue(string apiKey)
        {
            return $"Bearer {apiKey}";
        }

        private static void ApplyMultiPartFileToRequest(HttpRequestMessage requestMessage, string fileName, Stream fileStream, string purpose)
        {
            requestMessage.Headers.ExpectContinue = true;

            if (string.IsNullOrEmpty(fileName))
            {
                fileName = "blob";
            }

            var fileContent = new StreamContent(fileStream);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"file\"",
                FileName = $"\"{fileName}\""
            };

            fileContent.Headers.ContentType = new MediaTypeHeaderValue(MimeTypes.GetMimeType(fileName));

            var multiPartContent =
                new MultipartFormDataContent($"----------Upload:{ DateTime.UtcNow.Ticks :x}")
                {
                    { new StringContent(purpose), "\"purpose\"" },
                    fileContent
                };

            requestMessage.Content = multiPartContent;
        }

        private static StripeException BuildStripeException(StripeResponse response, HttpStatusCode statusCode, string requestUri, string responseContent)
        {
            var stripeError = requestUri.Contains("oauth")
                ? Mapper<StripeError>.MapFromJson(responseContent, null, response)
                : Mapper<StripeError>.MapFromJson(responseContent, "error", response);

            return new StripeException(statusCode, stripeError, stripeError.Message)
            {
                StripeResponse = response
            };
        }

        private static StripeResponse BuildResponseData(HttpResponseMessage response, string responseText)
        {
            var result = new StripeResponse
            {
                RequestId = response.Headers.Contains("Request-Id") ? response.Headers.GetValues("Request-Id").First() : "n/a",
                RequestDate = Convert.ToDateTime(response.Headers.GetValues("Date").First(), CultureInfo.InvariantCulture),
                ResponseJson = responseText
            };

            return result;
        }
    }
}
