// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using Newtonsoft.Json.Linq;

    public class ControlledByAlternateResourceException : StripeException
    {
        private ControlledByAlternateResourceException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message)
            : base(httpStatusCode, stripeError)
        {
        }

        internal static ControlledByAlternateResourceException Parse(
            HttpStatusCode httpStatusCode,
            JToken body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new ControlledByAlternateResourceException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}