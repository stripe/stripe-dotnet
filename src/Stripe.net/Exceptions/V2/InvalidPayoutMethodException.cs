// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using Newtonsoft.Json.Linq;

    public class InvalidPayoutMethodException : StripeException
    {
        private InvalidPayoutMethodException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message)
            : base(httpStatusCode, stripeError)
        {
        }

        internal static InvalidPayoutMethodException Parse(
            HttpStatusCode httpStatusCode,
            JToken body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new InvalidPayoutMethodException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}