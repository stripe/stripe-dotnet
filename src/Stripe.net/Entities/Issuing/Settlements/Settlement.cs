// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// When a non-stripe BIN is used, any use of an <a
    /// href="https://docs.stripe.com/issuing">issued card</a> must be settled directly with the
    /// card network. The net amount owed is represented by an Issuing <c>Settlement</c> object.
    /// </summary>
    public class Settlement : StripeEntity<Settlement>, IHasId, IHasMetadata, IHasObject
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
        /// The Bank Identification Number reflecting this settlement record.
        /// </summary>
        [JsonProperty("bin")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bin")]
#endif
        public string Bin { get; set; }

        /// <summary>
        /// The date that the transactions are cleared and posted to user's accounts.
        /// </summary>
        [JsonProperty("clearing_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("clearing_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ClearingDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The total interchange received as reimbursement for the transactions.
        /// </summary>
        [JsonProperty("interchange_fees_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interchange_fees_amount")]
#endif
        public long InterchangeFeesAmount { get; set; }

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
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The total net amount required to settle with the network.
        /// </summary>
        [JsonProperty("net_total_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("net_total_amount")]
#endif
        public long NetTotalAmount { get; set; }

        /// <summary>
        /// The card network for this settlement report. One of ["visa", "maestro"].
        /// One of: <c>maestro</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }

        /// <summary>
        /// The total amount of fees owed to the network.
        /// </summary>
        [JsonProperty("network_fees_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_fees_amount")]
#endif
        public long NetworkFeesAmount { get; set; }

        /// <summary>
        /// The Settlement Identification Number assigned by the network.
        /// </summary>
        [JsonProperty("network_settlement_identifier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_settlement_identifier")]
#endif
        public string NetworkSettlementIdentifier { get; set; }

        /// <summary>
        /// The total amount of any additional fees assessed by the card network.
        /// </summary>
        [JsonProperty("other_fees_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("other_fees_amount")]
#endif
        public long OtherFeesAmount { get; set; }

        /// <summary>
        /// The total number of additional fees assessed by the card network.
        /// </summary>
        [JsonProperty("other_fees_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("other_fees_count")]
#endif
        public long OtherFeesCount { get; set; }

        /// <summary>
        /// One of <c>international</c> or <c>uk_national_net</c>.
        /// </summary>
        [JsonProperty("settlement_service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settlement_service")]
#endif
        public string SettlementService { get; set; }

        /// <summary>
        /// The current processing status of this settlement.
        /// One of: <c>complete</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// The total transaction amount reflected in this settlement.
        /// </summary>
        [JsonProperty("transaction_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_amount")]
#endif
        public long TransactionAmount { get; set; }

        /// <summary>
        /// The total number of transactions reflected in this settlement.
        /// </summary>
        [JsonProperty("transaction_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_count")]
#endif
        public long TransactionCount { get; set; }
    }
}
