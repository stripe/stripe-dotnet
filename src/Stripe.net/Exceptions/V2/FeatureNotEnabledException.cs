// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using Newtonsoft.Json.Linq;

    public class FeatureNotEnabledException : StripeException
    {
        private FeatureNotEnabledException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message)
            : base(httpStatusCode, stripeError)
        {
        }

        internal static FeatureNotEnabledException Parse(
            HttpStatusCode httpStatusCode,
            JToken body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new FeatureNotEnabledException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}