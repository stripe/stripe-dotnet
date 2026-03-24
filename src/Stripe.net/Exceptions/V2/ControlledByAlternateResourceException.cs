// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    using System.Net;
    using System.Text.Json;
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
            JsonElement body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new ControlledByAlternateResourceException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}