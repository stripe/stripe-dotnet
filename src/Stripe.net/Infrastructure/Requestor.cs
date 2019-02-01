namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal static class Requestor
    {
        private static readonly string UserAgentString
            = $"Stripe/v1 .NetBindings/{StripeConfiguration.StripeNetVersion}";

        private static readonly string StripeClientUserAgentString
            = BuildStripeClientUserAgentString();

        static Requestor()
        {
            HttpClient =
                StripeConfiguration.HttpMessageHandler != null
                    ? new HttpClient(StripeConfiguration.HttpMessageHandler)
                    : new HttpClient();

            HttpClient.Timeout = StripeConfiguration.HttpTimeout;
        }

        internal static HttpClient HttpClient { get; private set; }

        internal static async Task<T> ExecuteRequestAsync<T>(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default(CancellationToken))
            where T : IStripeEntity
        {
            var response = await HttpClient.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            var stripeResponse = BuildResponseData(response, responseText);

            if (response.IsSuccessStatusCode)
            {
                var obj = StripeEntity.FromJson<T>(responseText);
                obj.StripeResponse = stripeResponse;
                return obj;
            }

            throw BuildStripeException(stripeResponse, response.StatusCode, requestMessage.RequestUri.AbsoluteUri, responseText);
        }

        internal static HttpRequestMessage GetRequestMessage(string url, HttpMethod method, RequestOptions requestOptions)
        {
            requestOptions.ApiKey = requestOptions.ApiKey ?? StripeConfiguration.ApiKey;

#if NET45
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
#endif

            var request = BuildRequest(method, url);

            request.Headers.Add(
                "Authorization",
                GetAuthorizationHeaderValue(requestOptions.ApiKey));

            if (requestOptions.StripeConnectAccountId != null)
            {
                request.Headers.Add("Stripe-Account", requestOptions.StripeConnectAccountId);
            }

            if (requestOptions.IdempotencyKey != null)
            {
                request.Headers.Add("Idempotency-Key", requestOptions.IdempotencyKey);
            }

            if (requestOptions.StripeVersion != null)
            {
                request.Headers.Add("Stripe-Version", requestOptions.StripeVersion);
            }
            else
            {
                request.Headers.Add("Stripe-Version", StripeConfiguration.ApiVersion);
            }

            request.Headers.UserAgent.ParseAdd(UserAgentString);
            request.Headers.Add("X-Stripe-Client-User-Agent", StripeClientUserAgentString);

            return request;
        }

        private static HttpRequestMessage BuildRequest(HttpMethod method, string url)
        {
            if (method != HttpMethod.Post)
            {
                return new HttpRequestMessage(method, new Uri(url));
            }

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

        internal static void ApplyMultiPartFileToRequest(HttpRequestMessage requestMessage, Stream stream, string purpose)
        {
            requestMessage.Headers.ExpectContinue = true;

            string fileName = "blob";

            #if NET45
            // Doing this on .NET Standard would require us to bump the minimum framework version
            // to .NET Standard 1.3, which isn't worth it since the filename is basically ignored
            // by the server.
            FileStream fileStream = stream as FileStream;
            if ((fileStream != null) && (!string.IsNullOrEmpty(fileStream.Name)))
            {
                fileName = fileStream.Name;
            }
            #endif

            var fileContent = new StreamContent(stream);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"file\"",
                FileName = $"\"{fileName}\""
            };

            fileContent.Headers.ContentType = new MediaTypeHeaderValue(MimeTypes.GetMimeType(fileName));

            var multiPartContent =
                new MultipartFormDataContent($"----------Upload:{DateTime.UtcNow.Ticks :x}")
                {
                    { new StringContent(purpose), "\"purpose\"" },
                    fileContent
                };

            requestMessage.Content = multiPartContent;
        }

        private static StripeException BuildStripeException(StripeResponse response, HttpStatusCode statusCode, string requestUri, string responseContent)
        {
            var stripeError = requestUri.Contains("oauth")
                ? StripeError.FromJson(responseContent)
                : StripeError.FromJson(JObject.Parse(responseContent)["error"].ToString());
            stripeError.StripeResponse = response;

            string message = !string.IsNullOrEmpty(stripeError.Message)
                ? stripeError.Message
                : stripeError.ErrorDescription;

            return new StripeException(statusCode, stripeError, message)
            {
                StripeResponse = response
            };
        }

        private static StripeResponse BuildResponseData(HttpResponseMessage response, string responseText)
        {
            var result = new StripeResponse
            {
                RequestId = response.Headers.Contains("Request-Id") ?
                    response.Headers.GetValues("Request-Id").First() :
                    "n/a",
                RequestDate = response.Headers.Contains("Date") ?
                    Convert.ToDateTime(response.Headers.GetValues("Date").First(), CultureInfo.InvariantCulture) :
                    default(DateTime),
                ResponseJson = responseText,
            };

            return result;
        }

        private static string BuildStripeClientUserAgentString()
        {
            var values = new Dictionary<string, string>
            {
                { "bindings_version", StripeConfiguration.StripeNetVersion },
                { "lang", ".net" },
                { "publisher", "stripe" },
                { "lang_version", RuntimeInformation.GetLanguageVersion() },
                { "os_version", RuntimeInformation.GetOSVersion() },
            };

#if NET45
            string monoVersion = RuntimeInformation.GetMonoVersion();
            if (!string.IsNullOrEmpty(monoVersion))
            {
                values.Add("mono_version", monoVersion);
            }
#endif

            return JsonConvert.SerializeObject(values, Formatting.None);
        }
    }
}
