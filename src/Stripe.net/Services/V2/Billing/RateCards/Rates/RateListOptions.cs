// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.RateCards
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RateListOptions : V2.ListOptions
    {
        /// <summary>
        /// Optionally filter by a Metered Item.
        /// </summary>
        [JsonProperty("metered_item")]
        [STJS.JsonPropertyName("metered_item")]
        public string MeteredItem { get; set; }

        /// <summary>
        /// Optionally filter by a RateCard version. If not specified, defaults to the latest
        /// version.
        /// </summary>
        [JsonProperty("rate_card_version")]
        [STJS.JsonPropertyName("rate_card_version")]
        public string RateCardVersion { get; set; }
    }
}
