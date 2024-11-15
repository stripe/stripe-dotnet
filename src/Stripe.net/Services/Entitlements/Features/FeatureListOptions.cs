// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FeatureListOptions : ListOptions
    {
        /// <summary>
        /// If set, filter results to only include features with the given archive status.
        /// </summary>
        [JsonProperty("archived")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("archived")]
#endif

        public bool? Archived { get; set; }

        /// <summary>
        /// If set, filter results to only include features with the given lookup_key.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif

        public string LookupKey { get; set; }
    }
}
