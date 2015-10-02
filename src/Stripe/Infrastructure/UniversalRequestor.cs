using System;
using Windows.Web.Http;
using Windows.Web.Http.Filters;

namespace Stripe.Infrastructure
{
    internal class UniversalRequestor : Requestor
    {
        private readonly HttpClient _httpClient = new HttpClient(new HttpBaseProtocolFilter { AllowUI = false });

        public override string GetString(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Get, requestOptions);

            return ExecuteRequestMessage(wr);
        }

        public override string PostString(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions);

            return ExecuteRequestMessage(wr);
        }

        public override string PostStringBearer(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, requestOptions, true);

            return ExecuteRequestMessage(wr);
        }

        public override string Delete(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetRequestMessage(url, HttpMethod.Delete, requestOptions);

            return ExecuteRequestMessage(wr);
        }

        private HttpRequestMessage GetRequestMessage(string url, HttpMethod method, StripeRequestOptions requestOptions, bool useBearer = false) {
            requestOptions.ApiKey = requestOptions.ApiKey ?? StripeConfiguration.GetApiKey();

            var request = new HttpRequestMessage(method, new Uri(url));

            foreach (var header in GetHeaders(requestOptions, useBearer))
            {
                request.Headers.Add(header.Key, header.Value);
            }

            request.Headers.UserAgent.Clear();
            request.Headers.UserAgent.TryParseAdd(UserAgent);

            return request;
        }

        private string ExecuteRequestMessage(HttpRequestMessage webRequest)
        {
            var response = _httpClient.SendRequestAsync(webRequest).AsTask().Result;
            var responseText = response.Content.ReadAsStringAsync().AsTask().Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsStringAsync().AsTask().Result;
            else
                throw BuildStripeException((System.Net.HttpStatusCode)(int)response.StatusCode, webRequest.RequestUri.AbsoluteUri, responseText);
        }
    }
}
