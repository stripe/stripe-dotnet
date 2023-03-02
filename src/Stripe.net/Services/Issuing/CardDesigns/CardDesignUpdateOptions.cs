// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardDesignUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A lookup key used to retrieve card designs dynamically from a static string. This may be
        /// up to 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Friendly display name. Providing an empty string will set the field to null.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether this card design is used to create cards when one is not specified.
        /// One of: <c>default</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("preference")]
        public string Preference { get; set; }

        /// <summary>
        /// If set to true, will atomically remove the lookup key from the existing card design, and
        /// assign it to this card design.
        /// </summary>
        [JsonProperty("transfer_lookup_key")]
        public bool? TransferLookupKey { get; set; }
    }
}
