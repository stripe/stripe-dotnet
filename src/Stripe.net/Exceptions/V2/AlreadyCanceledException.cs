// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using System.Text.Json;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class AlreadyCanceledException : StripeException
    {
        private AlreadyCanceledException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message)
            : base(httpStatusCode, stripeError)
        {
        }

        internal static AlreadyCanceledException Parse(
            HttpStatusCode httpStatusCode,
            JsonElement body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new AlreadyCanceledException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}