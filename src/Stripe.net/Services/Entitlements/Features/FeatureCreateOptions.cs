// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class FeatureCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A unique key you provide as your own system identifier. This may be up to 80 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The feature's name, for your own purpose, not meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
