// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.RateCards
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RateListOptions : V2.ListOptions
    {
        /// <summary>
        /// Optionally filter by a MeteredItem.
        /// </summary>
        [JsonProperty("metered_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metered_item")]
#endif
        public string MeteredItem { get; set; }

        /// <summary>
        /// Optionally filter by a RateCard version. If not specified, defaults to the latest
        /// version.
        /// </summary>
        [JsonProperty("rate_card_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_version")]
#endif
        public string RateCardVersion { get; set; }
    }
}
