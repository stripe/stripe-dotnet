// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using Newtonsoft.Json.Linq;

    public class QuotaExceededException : StripeException
    {
        private QuotaExceededException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message)
            : base(httpStatusCode, stripeError)
        {
        }

        internal static QuotaExceededException Parse(
            HttpStatusCode httpStatusCode,
            JToken body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new QuotaExceededException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}