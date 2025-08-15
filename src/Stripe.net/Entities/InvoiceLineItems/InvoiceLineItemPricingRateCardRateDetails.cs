// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemPricingRateCardRateDetails : StripeEntity<InvoiceLineItemPricingRateCardRateDetails>
    {
        [JsonProperty("rate_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card")]
#endif
        public string RateCard { get; set; }

        [JsonProperty("rate_card_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_rate")]
#endif
        public string RateCardRate { get; set; }

        [JsonProperty("metered_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metered_item")]
#endif
        public string MeteredItem { get; set; }
    }
}
