namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Stripe.Infrastructure.FormEncoding;

    internal static class Requestor
    {
        private static readonly string UserAgentString
            = $"Stripe/v1 .NetBindings/{StripeConfiguration.StripeNetVersion}";

        private static readonly string StripeClientUserAgentString
            = BuildStripeClientUserAgentString();

        static Requestor()
        {
#if NET45
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
#endif

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

        internal static HttpRequestMessage GetRequestMessage(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            var request = new Request(method, path, options, requestOptions);

            var requestMessage = new HttpRequestMessage(request.Method, request.Uri);

            // User agent headers. These are the same for every request.
            requestMessage.Headers.UserAgent.ParseAdd(UserAgentString);
            requestMessage.Headers.Add("X-Stripe-Client-User-Agent", StripeClientUserAgentString);

            // Request headers
            requestMessage.Headers.Authorization = request.AuthorizationHeader;
            foreach (var header in request.StripeHeaders)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            // Request body
            requestMessage.Content = request.Content;

            return requestMessage;
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
