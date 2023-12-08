// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Transaction represents a real transaction that affects a Financial Connections Account
    /// balance.
    /// </summary>
    public class Transaction : StripeEntity<Transaction>, IHasId, IHasObject
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
        /// The ID of the Financial Connections Account this transaction belongs to.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// The amount of this transaction, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The description of this transaction.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The status of the transaction.
        /// One of: <c>pending</c>, <c>posted</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        public TransactionStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Time at which the transaction was transacted. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("transacted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime TransactedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The token of the transaction refresh that last updated or created this transaction.
        /// </summary>
        [JsonProperty("transaction_refresh")]
        public string TransactionRefresh { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
