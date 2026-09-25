// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPaymentMethodOptionsUsBankAccountFinancialConnectionsManualEntry : StripeEntity<SessionPaymentMethodOptionsUsBankAccountFinancialConnectionsManualEntry>
    {
        /// <summary>
        /// Settings for configuring manual entry of account details.
        /// One of: <c>automatic</c>, or <c>custom</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }
    }
}
