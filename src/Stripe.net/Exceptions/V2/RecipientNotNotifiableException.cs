// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using Newtonsoft.Json.Linq;

    public class RecipientNotNotifiableException : StripeException
    {
        private RecipientNotNotifiableException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message)
            : base(httpStatusCode, stripeError)
        {
        }

        internal static RecipientNotNotifiableException Parse(
            HttpStatusCode httpStatusCode,
            JToken body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new RecipientNotNotifiableException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}