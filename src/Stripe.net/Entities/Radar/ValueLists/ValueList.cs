namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ValueList : StripeEntity<ValueList>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The name of the value list for use in rules.
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The name or email address of the user who created this value list.
        /// </summary>
        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The type of items in the value list. One of <c>card_fingerprint</c>, <c>card_bin</c>,
        /// <c>email</c>, <c>ip_address</c>, <c>country</c>, <c>string</c>, or
        /// <c>case_sensitive_string</c>.
        /// One of: <c>card_bin</c>, <c>card_fingerprint</c>, <c>case_sensitive_string</c>,
        /// <c>country</c>, <c>email</c>, <c>ip_address</c>, or <c>string</c>.
        /// </summary>
        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// List of items contained within this value list.
        /// </summary>
        [JsonProperty("list_items")]
        public StripeList<ValueListItem> ListItems { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The name of the value list.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
