// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    using System.Net;
    using System.Text.Json;
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
            JsonElement body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new InvalidPayoutMethodException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}