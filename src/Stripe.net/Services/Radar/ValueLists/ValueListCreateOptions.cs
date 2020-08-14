namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ValueListCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The name of the value list for use in rules.
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Type of the items in the value list. One of <c>card_fingerprint</c>, <c>card_bin</c>,
        /// <c>email</c>, <c>ip_address</c>, <c>country</c>, <c>string</c>, or
        /// <c>case_sensitive_string</c>. Use <c>string</c> if the item type is unknown or mixed.
        /// One of: <c>card_bin</c>, <c>card_fingerprint</c>, <c>case_sensitive_string</c>,
        /// <c>country</c>, <c>email</c>, <c>ip_address</c>, or <c>string</c>.
        /// </summary>
        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The human-readable name of the value list.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
