// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using Newtonsoft.Json.Linq;

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
            JToken body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new NonZeroBalanceException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}