// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using Newtonsoft.Json.Linq;

    public class FinancialAccountNotOpenException : StripeException
    {
        private FinancialAccountNotOpenException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message)
            : base(httpStatusCode, stripeError)
        {
        }

        internal static FinancialAccountNotOpenException Parse(
            HttpStatusCode httpStatusCode,
            JToken body)
        {
            var stripeError = StripeError.FromJson<StripeError>(body);
            return new FinancialAccountNotOpenException(httpStatusCode, stripeError, stripeError.Message);
        }
    }
}