// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentsOrchestrationOptions : INestedOptions
    {
        /// <summary>
        /// Whether this feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Merchant-provided reference for this payment, used for reconciliation.
        /// </summary>
        [JsonProperty("payment_reference")]
        [STJS.JsonPropertyName("payment_reference")]
        public string PaymentReference { get; set; }
    }
}
