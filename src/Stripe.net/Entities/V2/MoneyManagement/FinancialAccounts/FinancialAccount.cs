// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A FinancialAccount represents a balance and can be the source or destination of money
    /// movement.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccount : StripeEntity<FinancialAccount>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The FinancialAccount's balance, split into <c>available</c>, <c>inbound_pending</c>, and
        /// <c>outbound_pending</c> balances. Each balance is a hash keyed by lowercase currency
        /// codes, with an amount for each currency.
        /// </summary>
        [JsonProperty("balance")]
        [STJS.JsonPropertyName("balance")]
        public FinancialAccountBalance Balance { get; set; }

        /// <summary>
        /// Open Enum. The country where the LegalEntity associated with the FinancialAccount is
        /// based, represented as a two-letter country code.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Time at which the object was created. Represented as an RFC 3339 timestamp in UTC with
        /// millisecond precision, for example <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A descriptive name for the FinancialAccount, up to 50 characters long. This name appears
        /// in the Stripe Dashboard and embedded components.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If the FinancialAccount's <c>type</c> is <c>other</c>, this hash identifies its actual
        /// type. Upgrade your API version to see that type in <c>type</c>.
        /// </summary>
        [JsonProperty("other")]
        [STJS.JsonPropertyName("other")]
        public FinancialAccountOther Other { get; set; }

        /// <summary>
        /// Closed Enum. An enum representing the status of the FinancialAccount. This indicates
        /// whether or not the FinancialAccount can be used for any money movement flows.
        /// One of: <c>closed</c>, <c>open</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details related to the status of the FinancialAccount.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public FinancialAccountStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// If the FinancialAccount's <c>type</c> is <c>storage</c>, this hash contains details
        /// specific to that type.
        /// </summary>
        [JsonProperty("storage")]
        [STJS.JsonPropertyName("storage")]
        public FinancialAccountStorage Storage { get; set; }

        /// <summary>
        /// Closed Enum. The type of the FinancialAccount. Details specific to the type appear in
        /// the matching hash. For example, a <c>storage</c> FinancialAccount includes a
        /// <c>storage</c> hash.
        /// One of: <c>other</c>, or <c>storage</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
