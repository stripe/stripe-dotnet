// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce.ProductCatalog
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ImportCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The type of catalog data to import.
        /// One of: <c>inventory</c>, <c>pricing</c>, or <c>product</c>.
        /// </summary>
        [JsonProperty("feed_type")]
        [STJS.JsonPropertyName("feed_type")]
        public string FeedType { get; set; }

        /// <summary>
        /// Additional information about the import in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The strategy for handling existing catalog data during import.
        /// One of: <c>replace</c>, or <c>upsert</c>.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }
    }
}
