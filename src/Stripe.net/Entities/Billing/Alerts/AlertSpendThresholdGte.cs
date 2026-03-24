// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertSpendThresholdGte : StripeEntity<AlertSpendThresholdGte>
    {
        /// <summary>
        /// The monetary amount. Present when type is <c>amount</c>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public AlertSpendThresholdGteAmount Amount { get; set; }

        /// <summary>
        /// The custom pricing unit amount. Present when type is <c>custom_pricing_unit</c>.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
        [STJS.JsonPropertyName("custom_pricing_unit")]
        public AlertSpendThresholdGteCustomPricingUnit CustomPricingUnit { get; set; }

        /// <summary>
        /// The type of the threshold amount.
        /// One of: <c>amount</c>, or <c>custom_pricing_unit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
