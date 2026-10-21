// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemMetronomeCommitCommitSpecifier : StripeEntity<SessionItemMetronomeCommitCommitSpecifier>
    {
        /// <summary>
        /// Key-value pairs for presentation group filters.
        /// </summary>
        [JsonProperty("presentation_group_values")]
        [STJS.JsonPropertyName("presentation_group_values")]
        public Dictionary<string, string> PresentationGroupValues { get; set; }

        /// <summary>
        /// Key-value pairs for pricing group filters.
        /// </summary>
        [JsonProperty("pricing_group_values")]
        [STJS.JsonPropertyName("pricing_group_values")]
        public Dictionary<string, string> PricingGroupValues { get; set; }

        /// <summary>
        /// Metronome product ID to scope this specifier to.
        /// </summary>
        [JsonProperty("product_id")]
        [STJS.JsonPropertyName("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// Metronome product tags to scope this specifier to. Products must have all specified
        /// tags.
        /// </summary>
        [JsonProperty("product_tags")]
        [STJS.JsonPropertyName("product_tags")]
        public List<string> ProductTags { get; set; }
    }
}
