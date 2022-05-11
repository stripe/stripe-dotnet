// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsUsBankAccount : StripeEntity<SessionPaymentMethodOptionsUsBankAccount>
    {
        [JsonProperty("financial_connections")]
        public SessionPaymentMethodOptionsUsBankAccountFinancialConnections FinancialConnections { get; set; }

        /// <summary>
        /// Bank account verification method.
        /// One of: <c>automatic</c>, or <c>instant</c>.
        /// </summary>
        [JsonProperty("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
