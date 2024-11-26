// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Value lists allow you to group values together which can then be referenced in rules.
    ///
    /// Related guide: <a href="https://stripe.com/docs/radar/lists#managing-list-items">Default
    /// Stripe lists</a>.
    /// </summary>
    public class ValueList : StripeEntity<ValueList>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The name of the value list for use in rules.
        /// </summary>
        [JsonProperty("alias")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alias")]
#endif
        public string Alias { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The name or email address of the user who created this value list.
        /// </summary>
        [JsonProperty("created_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_by")]
#endif
        public string CreatedBy { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif
        public bool? Deleted { get; set; }

        /// <summary>
        /// The type of items in the value list. One of <c>card_fingerprint</c>,
        /// <c>us_bank_account_fingerprint</c>, <c>sepa_debit_fingerprint</c>, <c>card_bin</c>,
        /// <c>email</c>, <c>ip_address</c>, <c>country</c>, <c>string</c>,
        /// <c>case_sensitive_string</c>, or <c>customer_id</c>.
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
        /// List of items contained within this value list.
        /// </summary>
        [JsonProperty("list_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("list_items")]
#endif
        public StripeList<ValueListItem> ListItems { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The name of the value list.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
