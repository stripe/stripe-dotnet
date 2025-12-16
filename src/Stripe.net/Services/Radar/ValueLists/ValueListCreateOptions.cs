// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ValueListCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The name of the value list for use in rules.
        /// </summary>
        [JsonProperty("alias")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alias")]
#endif
        public string Alias { get; set; }

        /// <summary>
        /// Type of the items in the value list. One of <c>card_fingerprint</c>, <c>card_bin</c>,
        /// <c>email</c>, <c>ip_address</c>, <c>country</c>, <c>string</c>,
        /// <c>case_sensitive_string</c>, <c>customer_id</c>, <c>sepa_debit_fingerprint</c>, or
        /// <c>us_bank_account_fingerprint</c>. Use <c>string</c> if the item type is unknown or
        /// mixed.
        /// One of: <c>card_bin</c>, <c>card_fingerprint</c>, <c>case_sensitive_string</c>,
        /// <c>country</c>, <c>customer_id</c>, <c>email</c>, <c>ip_address</c>,
        /// <c>sepa_debit_fingerprint</c>, <c>string</c>, or <c>us_bank_account_fingerprint</c>.
        /// </summary>
        [JsonProperty("item_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("item_type")]
#endif
        public string ItemType { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The human-readable name of the value list.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
