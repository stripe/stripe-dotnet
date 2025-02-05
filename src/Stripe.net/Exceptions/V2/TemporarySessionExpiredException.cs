// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using Newtonsoft.Json.Linq;

    public class TemporarySessionExpiredException : StripeException
    {
        private TemporarySessionExpiredException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message)
            : base(httpStatusCode, stripeError)
        {
        }

        internal static TemporarySessionExpiredException Parse(
            HttpStatusCode httpStatusCode,
            JToken body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new TemporarySessionExpiredException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}