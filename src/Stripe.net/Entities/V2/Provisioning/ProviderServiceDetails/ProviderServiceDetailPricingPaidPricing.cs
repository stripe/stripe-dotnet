// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderServiceDetailPricingPaidPricing : StripeEntity<ProviderServiceDetailPricingPaidPricing>
    {
        /// <summary>
        /// Service configuration values for which this pricing entry applies.
        /// </summary>
        [JsonProperty("configuration")]
        [STJS.JsonPropertyName("configuration")]
        public Dictionary<string, object> Configuration { get; set; }

        /// <summary>
        /// Additional display information about the price.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Provider-supplied pricing terms, set when <c>type</c> is <c>freeform</c>.
        /// </summary>
        [JsonProperty("freeform")]
        [STJS.JsonPropertyName("freeform")]
        public string Freeform { get; set; }

        /// <summary>
        /// Whether this entry is the fallback when no configuration-specific entry matches.
        /// </summary>
        [JsonProperty("is_default")]
        [STJS.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Kind of pricing represented by this entry.
        /// One of: <c>free</c>, or <c>freeform</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
