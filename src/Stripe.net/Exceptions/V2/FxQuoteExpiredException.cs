// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using System.Text.Json;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class FxQuoteExpiredException : StripeException
    {
        private FxQuoteExpiredException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message)
            : base(httpStatusCode, stripeError)
        {
        }

        internal static FxQuoteExpiredException Parse(
            HttpStatusCode httpStatusCode,
            JsonElement body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new FxQuoteExpiredException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}