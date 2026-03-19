// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemPricingRateCardCustomPricingUnitOverageRateDetails : StripeEntity<InvoiceItemPricingRateCardCustomPricingUnitOverageRateDetails>
    {
        /// <summary>
        /// The ID of the custom pricing unit this item is associated with.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
        [STJS.JsonPropertyName("custom_pricing_unit")]
        public string CustomPricingUnit { get; set; }

        /// <summary>
        /// The ID of the custom pricing unit overage rate this item is associated with.
        /// </summary>
        [JsonProperty("custom_pricing_unit_overage_rate")]
        [STJS.JsonPropertyName("custom_pricing_unit_overage_rate")]
        public string CustomPricingUnitOverageRate { get; set; }

        /// <summary>
        /// The ID of the one-time item this custom pricing unit overage rate is associated with.
        /// </summary>
        [JsonProperty("one_time_item")]
        [STJS.JsonPropertyName("one_time_item")]
        public string OneTimeItem { get; set; }

        /// <summary>
        /// The ID of the rate card this item is associated with.
        /// </summary>
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public string RateCard { get; set; }
    }
}
