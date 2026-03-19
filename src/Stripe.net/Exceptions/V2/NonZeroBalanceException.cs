// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using System.Text.Json;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class NonZeroBalanceException : StripeException
    {
        private NonZeroBalanceException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message)
            : base(httpStatusCode, stripeError)
        {
        }

        internal static NonZeroBalanceException Parse(
            HttpStatusCode httpStatusCode,
            JsonElement body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new NonZeroBalanceException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}