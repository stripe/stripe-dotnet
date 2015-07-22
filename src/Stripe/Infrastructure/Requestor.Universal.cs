#if WINDOWS_UAP
using System;
using System.Text;
using Windows.Web.Http;
using Windows.Web.Http.Filters;


namespace Stripe
{
    internal static class Requestor
    {
        private static HttpClient _httpClient = new HttpClient(new HttpBaseProtocolFilter { AllowUI = false });

        public static string GetString(string url, string apiKey = null)
        {
            var wr = GetRequestMessage(url, HttpMethod.Get, apiKey);

            return ExecuteWebRequest(wr);
        }

        public static string PostString(string url, string apiKey = null)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, apiKey);

            return ExecuteWebRequest(wr);
        }

        public static string PostStringBearer(string url, string apiKey = null)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, apiKey, true);

            return ExecuteWebRequest(wr);
        }

        public static string Delete(string url, string apiKey = null)
        {
            var wr = GetRequestMessage(url, HttpMethod.Delete, apiKey);

            return ExecuteWebRequest(wr);
        }

        internal static HttpRequestMessage GetRequestMessage(string url, HttpMethod method, string apiKey = null, bool useBearer = false)
        {
            apiKey = apiKey ?? StripeConfiguration.GetApiKey();

            var request = new HttpRequestMessage(method, new Uri(url));

            if (!useBearer)
                request.Headers.Add("Authorization", GetAuthorizationHeaderValue(apiKey));
            else
                request.Headers.Add("Authorization", GetAuthorizationHeaderValueBearer(apiKey));

            request.Headers.Add("Stripe-Version", StripeConfiguration.ApiVersion);
            request.Headers.UserAgent.Clear();
            request.Headers.UserAgent.TryParseAdd("Stripe.net (https://github.com/jaymedavis/stripe.net)");
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

        private static string ExecuteWebRequest(HttpRequestMessage webRequest)
        {
            var response = _httpClient.SendRequestAsync(webRequest).AsTask().Result;
            var responseText = response.Content.ReadAsStringAsync().AsTask().Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsStringAsync().AsTask().Result;

            var stripeError = new StripeError();

            if (webRequest.RequestUri.AbsoluteUri.Contains("oauth"))
                stripeError = Mapper<StripeError>.MapFromJson(responseText);
            else
                stripeError = Mapper<StripeError>.MapFromJson(responseText, "error");

            throw new StripeException((System.Net.HttpStatusCode)(int)response.StatusCode, stripeError, stripeError.Message);
        }
    }
}
#endif
