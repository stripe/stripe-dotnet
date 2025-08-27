// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemParentRateCardSubscriptionDetails : StripeEntity<InvoiceLineItemParentRateCardSubscriptionDetails>
    {
        /// <summary>
        /// The invoice item that generated this line item.
        /// </summary>
        [JsonProperty("invoice_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_item")]
#endif
        public string InvoiceItem { get; set; }

        /// <summary>
        /// The pricing plan subscription that manages the rate card subscription.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription")]
#endif
        public string PricingPlanSubscription { get; set; }

        /// <summary>
        /// The pricing plan version at the time this line item was generated.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_version")]
#endif
        public string PricingPlanVersion { get; set; }

        /// <summary>
        /// The rate card subscription that generated this line item.
        /// </summary>
        [JsonProperty("rate_card_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_subscription")]
#endif
        public string RateCardSubscription { get; set; }

        /// <summary>
        /// The rate card version at the time this line item was generated.
        /// </summary>
        [JsonProperty("rate_card_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_version")]
#endif
        public string RateCardVersion { get; set; }
    }
}
