// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertSpendThresholdGte : StripeEntity<AlertSpendThresholdGte>
    {
        /// <summary>
        /// The monetary amount. Present when type is <c>amount</c>.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public AlertSpendThresholdGteAmount Amount { get; set; }

        /// <summary>
        /// The custom pricing unit amount. Present when type is <c>custom_pricing_unit</c>.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit")]
#endif
        public AlertSpendThresholdGteCustomPricingUnit CustomPricingUnit { get; set; }

        /// <summary>
        /// The type of the threshold amount.
        /// One of: <c>amount</c>, or <c>custom_pricing_unit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
