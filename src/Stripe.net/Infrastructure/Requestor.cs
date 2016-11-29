using System;
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

        public static StripeResponse PostStringBearer(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions, true);

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
            var response = HttpClient.SendAsync(requestMessage).Result;
            var responseText = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
                return BuildResponseData(response, responseText);

            throw BuildStripeException(response.StatusCode, requestMessage.RequestUri.AbsoluteUri, responseText);
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

        public static Task<StripeResponse> PostStringBearerAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions, true);

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
            var response = await HttpClient.SendAsync(requestMessage, cancellationToken);

            if (response.IsSuccessStatusCode)
                return BuildResponseData(response, await response.Content.ReadAsStringAsync());

            throw BuildStripeException(response.StatusCode, requestMessage.RequestUri.AbsoluteUri, await response.Content.ReadAsStringAsync());
        }



        private static HttpRequestMessage GetRequestMessage(string url, HttpMethod method, StripeRequestOptions requestOptions, bool useBearer = false)
        {
            requestOptions.ApiKey = requestOptions.ApiKey ?? StripeConfiguration.GetApiKey();

#if NET45
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
#endif

            var request = BuildRequest(method, url);

            request.Headers.Add("Authorization",
                !useBearer
                    ? GetAuthorizationHeaderValue(requestOptions.ApiKey)
                    : GetAuthorizationHeaderValueBearer(requestOptions.ApiKey));

            if (requestOptions.StripeConnectAccountId != null)
                request.Headers.Add("Stripe-Account", requestOptions.StripeConnectAccountId);

            if (requestOptions.IdempotencyKey != null)
                request.Headers.Add("Idempotency-Key", requestOptions.IdempotencyKey);

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
            var token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apiKey}:"));
            return $"Basic {token}";
        }

        private static string GetAuthorizationHeaderValueBearer(string apiKey)
        {
            return $"Bearer {apiKey}";
        }

        private static void ApplyMultiPartFileToRequest(HttpRequestMessage requestMessage, string fileName, Stream fileStream, string purpose)
        {
            requestMessage.Headers.ExpectContinue = true;

            var fileContent = new StreamContent(fileStream);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"file\"",
                FileName = $"\"{fileName}\""
            };

            fileContent.Headers.ContentType = new MediaTypeHeaderValue(MimeTypes.GetMimeType(fileName));

            var multiPartContent =
                new MultipartFormDataContent($"----------Upload: { DateTime.UtcNow.Ticks.ToString("x") }")
                {
                    { new StringContent(purpose), "\"purpose\"" },
                    fileContent
                };

            requestMessage.Content = multiPartContent;
        }

        private static StripeException BuildStripeException(HttpStatusCode statusCode, string requestUri, string responseContent)
        {
            var stripeError = requestUri.Contains("oauth") 
                ? Mapper<StripeError>.MapFromJson(responseContent) 
                : Mapper<StripeError>.MapFromJson(responseContent, "error");

            return new StripeException(statusCode, stripeError, stripeError.Message);
        }

        private static StripeResponse BuildResponseData(HttpResponseMessage response, string responseText)
        {
            var result = new StripeResponse
            {
                RequestId = response.Headers.GetValues("Request-Id").First(),
                RequestDate = Convert.ToDateTime(response.Headers.GetValues("Date").First()),
                ResponseJson = responseText
            };

            return result;
        }
    }
}