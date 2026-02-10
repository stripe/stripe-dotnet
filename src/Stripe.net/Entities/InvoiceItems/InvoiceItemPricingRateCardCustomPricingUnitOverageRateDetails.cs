// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceItemPricingRateCardCustomPricingUnitOverageRateDetails : StripeEntity<InvoiceItemPricingRateCardCustomPricingUnitOverageRateDetails>
    {
        /// <summary>
        /// The ID of the custom pricing unit this item is associated with.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit")]
#endif
        public string CustomPricingUnit { get; set; }

        /// <summary>
        /// The ID of the custom pricing unit overage rate this item is associated with.
        /// </summary>
        [JsonProperty("custom_pricing_unit_overage_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit_overage_rate")]
#endif
        public string CustomPricingUnitOverageRate { get; set; }

        /// <summary>
        /// The ID of the one-time item this custom pricing unit overage rate is associated with.
        /// </summary>
        [JsonProperty("one_time_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("one_time_item")]
#endif
        public string OneTimeItem { get; set; }

        /// <summary>
        /// The ID of the rate card this item is associated with.
        /// </summary>
        [JsonProperty("rate_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card")]
#endif
        public string RateCard { get; set; }
    }
}
