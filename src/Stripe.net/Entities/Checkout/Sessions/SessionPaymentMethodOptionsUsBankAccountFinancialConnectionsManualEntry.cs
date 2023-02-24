// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsUsBankAccountFinancialConnectionsManualEntry : StripeEntity<SessionPaymentMethodOptionsUsBankAccountFinancialConnectionsManualEntry>
    {
        /// <summary>
        /// Settings for configuring manual entry of account details.
        /// One of: <c>automatic</c>, or <c>custom</c>.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }
}
