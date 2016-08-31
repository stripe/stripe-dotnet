using System;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    internal static class Requestor
    {
        internal static HttpClient HttpClient { get; private set; }
        internal static string Version { get; }

        static Requestor()
        {
            HttpClient = new HttpClient();
        }

        public static string GetString(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Get, requestOptions);

            return ExecuteRequest(wr);
        }

        public static string PostString(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions);

            return ExecuteRequest(wr);
        }

        public static string Delete(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Delete, requestOptions);

            return ExecuteRequest(wr);
        }

        public static string PostStringBearer(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions, true);

            return ExecuteRequest(wr);
        }

        public static Task<string> GetStringAsync(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Get, requestOptions);

            return ExecuteRequestAsync(wr);
        }

        public static Task<string> PostStringAsync(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions);

            return ExecuteRequestAsync(wr);
        }

        public static Task<string> DeleteAsync(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Delete, requestOptions);

            return ExecuteRequestAsync(wr);
        }

        public static Task<string> PostStringBearerAsync(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions, true);

            return ExecuteRequestAsync(wr);
        }

        internal static HttpRequestMessage GetRequestMessage(string url, HttpMethod method, StripeRequestOptions requestOptions, bool useBearer = false)
        {
            requestOptions.ApiKey = requestOptions.ApiKey ?? StripeConfiguration.GetApiKey();

#if !PORTABLE
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
#endif

            var request = BuildRequest(method, url);

            if(!useBearer)
                request.Headers.Add("Authorization", GetAuthorizationHeaderValue(requestOptions.ApiKey));
            else
                request.Headers.Add("Authorization", GetAuthorizationHeaderValueBearer(requestOptions.ApiKey));

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
            if (method == HttpMethod.Post)
            {
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

            return new HttpRequestMessage(method, new Uri(url));
        }

        private static string GetAuthorizationHeaderValue(string apiKey)
        {
            var token = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:", apiKey)));
            return string.Format("Basic {0}", token);
        }

        private static string GetAuthorizationHeaderValueBearer(string apiKey)
        {
            return string.Format("Bearer {0}", apiKey);
        }

        private static string ExecuteRequest(HttpRequestMessage requestMessage)
        {
            var response = HttpClient.SendAsync(requestMessage).Result;
            var responseText = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
                return responseText;

            throw BuildStripeException(response.StatusCode, requestMessage.RequestUri.AbsoluteUri, responseText);
        }

        private static async Task<string> ExecuteRequestAsync(HttpRequestMessage requestMessage)
        {
            var response = await HttpClient.SendAsync(requestMessage);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            throw BuildStripeException(response.StatusCode, requestMessage.RequestUri.AbsoluteUri, await response.Content.ReadAsStringAsync());
        }

        internal static StripeException BuildStripeException(HttpStatusCode statusCode, string requestUri, string responseContent)
        {
            var stripeError = new StripeError();

            if (requestUri.Contains("oauth"))
                stripeError = Mapper<StripeError>.MapFromJson(responseContent);
            else
                stripeError = Mapper<StripeError>.MapFromJson(responseContent, "error");

            return new StripeException(statusCode, stripeError, stripeError.Message);
        }
    }
}