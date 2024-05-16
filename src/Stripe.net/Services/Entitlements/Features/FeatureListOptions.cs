// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;

    public class FeatureListOptions : ListOptions
    {
        /// <summary>
        /// If set, filter results to only include features with the given archive status.
        /// </summary>
        [JsonProperty("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// If set, filter results to only include features with the given lookup_key.
        /// </summary>
        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }
    }
}
