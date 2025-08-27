// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemPricingRateCardRateDetails : StripeEntity<InvoiceLineItemPricingRateCardRateDetails>
    {
        /// <summary>
        /// The ID of billable item this item is associated with.
        /// </summary>
        [JsonProperty("metered_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metered_item")]
#endif
        public string MeteredItem { get; set; }

        /// <summary>
        /// The ID of the rate card this item is associated with.
        /// </summary>
        [JsonProperty("rate_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card")]
#endif
        public string RateCard { get; set; }

        /// <summary>
        /// The ID of the rate card rate this item is associated with.
        /// </summary>
        [JsonProperty("rate_card_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_rate")]
#endif
        public string RateCardRate { get; set; }
    }
}
