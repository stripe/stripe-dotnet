using Stripe.Infrastructure;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Stripe {
    internal interface IRequestor
    {
        string GetString(string url, StripeRequestOptions requestOptions);
        string PostString(string url, StripeRequestOptions requestOptions);
        string Delete(string url, StripeRequestOptions requestOptions);
        string PostStringBearer(string url, StripeRequestOptions requestOptions);
    }

    internal abstract class Requestor : IRequestor
    {
        protected const string UserAgent = "Stripe.net (https://github.com/jaymedavis/stripe.net)";
        internal static IRequestor Instance { get; private set; }

        static Requestor()
        {
#if WINDOWS_UWP
            Instance = new UniversalRequestor();
#else
            Instance = new DefaultRequestor();
#endif
        }

        public abstract string GetString(string url, StripeRequestOptions requestOptions);
        public abstract string PostString(string url, StripeRequestOptions requestOptions);
        public abstract string Delete(string url, StripeRequestOptions requestOptions);
        public abstract string PostStringBearer(string url, StripeRequestOptions requestOptions);

        protected IDictionary<string, string> GetHeaders(StripeRequestOptions requestOptions, bool useBearer)
        {
            requestOptions.ApiKey = requestOptions.ApiKey ?? StripeConfiguration.GetApiKey();

            var result = new Dictionary<string, string>();

            if (!useBearer)
                result.Add("Authorization", GetAuthorizationHeaderValue(requestOptions.ApiKey));
            else
                result.Add("Authorization", GetAuthorizationHeaderValueBearer(requestOptions.ApiKey));

            result.Add("Stripe-Version", StripeConfiguration.ApiVersion);

            if (requestOptions.StripeConnectAccountId != null)
                result.Add("Stripe-Account", requestOptions.StripeConnectAccountId);

            if (requestOptions.IdempotencyKey != null)
                result.Add("Idempotency-Key", requestOptions.IdempotencyKey);

            return result;
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

        protected StripeException BuildStripeException(HttpStatusCode statusCode, string requestUri, string responseContent)
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
