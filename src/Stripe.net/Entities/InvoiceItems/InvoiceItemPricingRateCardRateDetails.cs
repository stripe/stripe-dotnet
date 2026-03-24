// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemPricingRateCardRateDetails : StripeEntity<InvoiceItemPricingRateCardRateDetails>
    {
        /// <summary>
        /// The ID of billable item this item is associated with.
        /// </summary>
        [JsonProperty("metered_item")]
        [STJS.JsonPropertyName("metered_item")]
        public string MeteredItem { get; set; }

        /// <summary>
        /// The ID of the rate card this item is associated with.
        /// </summary>
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public string RateCard { get; set; }

        /// <summary>
        /// The ID of the rate card rate this item is associated with.
        /// </summary>
        [JsonProperty("rate_card_rate")]
        [STJS.JsonPropertyName("rate_card_rate")]
        public string RateCardRate { get; set; }
    }
}
