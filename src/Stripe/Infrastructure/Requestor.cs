using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Stripe
{
    internal static class Requestor
    {
        
        /// <summary>
        /// The internal HttpClient instance to be used by the Requestor.
        /// </summary>
        internal static HttpClient HttpClient { get; }
		
		internal static string Version { get; }

        /// <summary>
        /// Initializes the HTTP request internals.
        /// </summary>
        static Requestor()
        {
            var handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }

            HttpClient = new HttpClient(handler);
			
            var thisAssembly = typeof(Requestor).GetTypeInfo().Assembly;
            var thisAssemblyName = new AssemblyName(thisAssembly.FullName);
            Version = thisAssemblyName.Version.ToString(3);
        }

        public static string GetString(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Get, requestOptions);

            return ExecuteRequest(wr).Result;
        }

        public static string PostString(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions);

            return ExecuteRequest(wr).Result;
        }

        public static string Delete(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Delete, requestOptions);

            return ExecuteRequest(wr).Result;
        }

        public static string PostStringBearer(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions, true);

            return ExecuteRequest(wr).Result;
        }

        internal static HttpRequestMessage GetRequestMessage(string url, HttpMethod method, StripeRequestOptions requestOptions, bool useBearer = false)
        {
            requestOptions.ApiKey = requestOptions.ApiKey ?? StripeConfiguration.GetApiKey();

            var request = new HttpRequestMessage(method, new Uri(url));

            if(!useBearer)
                request.Headers.Add("Authorization", GetAuthorizationHeaderValue(requestOptions.ApiKey));
            else
                request.Headers.Add("Authorization", GetAuthorizationHeaderValueBearer(requestOptions.ApiKey));

            request.Headers.Add("Stripe-Version", StripeConfiguration.ApiVersion);

            if (requestOptions.StripeConnectAccountId != null)
                request.Headers.Add("Stripe-Account", requestOptions.StripeConnectAccountId);

            if (requestOptions.IdempotencyKey != null)
                request.Headers.Add("Idempotency-Key", requestOptions.IdempotencyKey);

            request.Headers.UserAgent.Clear();
            request.Headers.UserAgent.TryParseAdd($"Stripe.net {Version} (https://github.com/jaymedavis/stripe.net)");

            //request.ContentType = "application/x-www-form-urlencoded";

            return request;
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

        private async static Task<string> ExecuteRequest(HttpRequestMessage requestMessage)
        {
            var response = await HttpClient.SendAsync(requestMessage);
            var responseText = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return responseText;
            }
            else
            {
                throw BuildStripeException(response.StatusCode, requestMessage.RequestUri.AbsoluteUri, responseText);
            }
        }

        internal static StripeException BuildStripeException(HttpStatusCode statusCode, string requestUri, string responseContent)
        {
            var stripeError = new StripeError();

            if (requestUri.Contains("oauth"))
                stripeError = Mapper<StripeError>.MapFromJson(responseContent);
            else
                stripeError = Mapper<StripeError>.MapFromJson(responseContent);

            return new StripeException(statusCode, stripeError, stripeError.Message);
        }

    }

}