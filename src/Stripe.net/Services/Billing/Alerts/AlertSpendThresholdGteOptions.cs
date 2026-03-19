// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertSpendThresholdGteOptions : INestedOptions
    {
        /// <summary>
        /// The monetary amount. Required when type is <c>amount</c>. The threshold is the
        /// total_before_tax, the amount consumed after all credits and discounts are applied, but
        /// before tax is applied.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public AlertSpendThresholdGteAmountOptions Amount { get; set; }

        /// <summary>
        /// The custom pricing unit amount. Required when type is <c>custom_pricing_unit</c>.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
        [STJS.JsonPropertyName("custom_pricing_unit")]
        public AlertSpendThresholdGteCustomPricingUnitOptions CustomPricingUnit { get; set; }

        /// <summary>
        /// The type of the threshold amount.
        /// One of: <c>amount</c>, or <c>custom_pricing_unit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
