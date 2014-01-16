using System;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Stripe
{
    internal static class Requestor
    {
        private static HttpClient client = new HttpClient();

        private static IEnumerable<KeyValuePair<string, string>> EmptyFormData =
            new List<KeyValuePair<string, string>>(); 

        public static async Task<string> GetStringAsync(string url, string apiKey = null)
        {
            var response = await PerformRequest(url, "GET", null, apiKey);
            return await ProcessResponse(response);
        }

        public static async Task<string> PostStringAsync(string url, IEnumerable<KeyValuePair<string, string>> formData, string apiKey = null)
        {
            var response = await PerformRequest(url, "POST", formData, apiKey);
            return await ProcessResponse(response);
        }

        public static async Task<string> PostStringBearerAsync(string url, IEnumerable<KeyValuePair<string, string>> formData, string apiKey = null)
        {
            var response = await PerformRequest(url, "POST", formData, apiKey, true);
            return await ProcessResponse(response);
        }

        public static async Task<string> DeleteAsync(string url, string apiKey = null)
        {
            var response = await PerformRequest(url, "DELETE", null, apiKey);
            return await ProcessResponse(response);
        }

        private static async Task<HttpResponseMessage> PerformRequest(string url, string method, IEnumerable<KeyValuePair<string, string>> formData = null, string apiKey = null, bool useBearer = false)
        {
            apiKey = apiKey ?? StripeConfiguration.GetApiKey();

            var headers = new List<KeyValuePair<string, string>>
            {
                !useBearer
                    ? new KeyValuePair<string, string>("Authorization", GetAuthorizationHeaderValue(apiKey))
                    : new KeyValuePair<string, string>("Authorization", GetAuthorizationHeaderValueBearer(apiKey)),
                new KeyValuePair<string, string>("User-Agent", "Stripe.net (https://github.com/jaymedavis/stripe.net)")
            };

            return await GetBaseRequest(client, url, method, headers, formData);
        }

        private static async Task<string> ProcessResponse(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var stripeError = new StripeError();

                if (response.RequestMessage.RequestUri.ToString().Contains("oauth"))
                    stripeError = Mapper<StripeError>.MapFromJson(content);
                else
                    stripeError = Mapper<StripeError>.MapFromJson(content, "error");

                throw new StripeException(response.StatusCode, stripeError, stripeError.Message);
            }
        }


        private static async Task<HttpResponseMessage> GetBaseRequest(HttpClient client, string url, string httpMethod, IEnumerable<KeyValuePair<string, string>> headersToAdd, IEnumerable<KeyValuePair<string, string>> formData = null)
        {
            client.DefaultRequestHeaders.Clear();
            foreach (var header in headersToAdd)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }
            switch (httpMethod)
            {
                case "GET":
                    return await client.GetAsync(url);
                case "POST":
                    return await client.PostAsync(url, new FormUrlEncodedContent(formData ?? EmptyFormData));
                case "DELETE":
                    return await client.DeleteAsync(url);
                default:
                    throw new ArgumentException("httpMethod must be one of GET/POST/DELETE", "httpMethod");
            }
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
    }
}