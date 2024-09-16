// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// When a non-stripe BIN is used, any use of an <a
    /// href="https://stripe.com/docs/issuing">issued card</a> must be settled directly with the
    /// card network. The net amount owed is represented by an Issuing <c>Settlement</c> object.
    /// </summary>
    public class Settlement : StripeEntity<Settlement>, IHasId, IHasMetadata, IHasObject
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
        /// The Bank Identification Number reflecting this settlement record.
        /// </summary>
        [JsonProperty("bin")]
        public string Bin { get; set; }

        /// <summary>
        /// The date that the transactions are cleared and posted to user's accounts.
        /// </summary>
        [JsonProperty("clearing_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ClearingDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The total interchange received as reimbursement for the transactions.
        /// </summary>
        [JsonProperty("interchange_fees")]
        public long InterchangeFees { get; set; }

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
        /// The total net amount required to settle with the network.
        /// </summary>
        [JsonProperty("net_total")]
        public long NetTotal { get; set; }

        /// <summary>
        /// The card network for this settlement report. One of ["visa", "maestro"].
        /// One of: <c>maestro</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// The total amount of fees owed to the network.
        /// </summary>
        [JsonProperty("network_fees")]
        public long NetworkFees { get; set; }

        /// <summary>
        /// The Settlement Identification Number assigned by the network.
        /// </summary>
        [JsonProperty("network_settlement_identifier")]
        public string NetworkSettlementIdentifier { get; set; }

        /// <summary>
        /// One of <c>international</c> or <c>uk_national_net</c>.
        /// </summary>
        [JsonProperty("settlement_service")]
        public string SettlementService { get; set; }

        /// <summary>
        /// The current processing status of this settlement.
        /// One of: <c>complete</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The total number of transactions reflected in this settlement.
        /// </summary>
        [JsonProperty("transaction_count")]
        public long TransactionCount { get; set; }

        /// <summary>
        /// The total transaction amount reflected in this settlement.
        /// </summary>
        [JsonProperty("transaction_volume")]
        public long TransactionVolume { get; set; }
    }
}
