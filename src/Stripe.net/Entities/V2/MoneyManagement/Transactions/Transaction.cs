// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Use Transactions to view changes to your FinancialAccount balance over time. Every flow
    /// that moves money, such as OutboundPayments or ReceivedCredits, will have one or more
    /// Transactions that describes how the flow impacted your balance. Note that while the
    /// FinancialAccount balance will always be up to date, be aware that Transactions and
    /// TransactionEntries are created shortly after to reflect changes.
    /// </summary>
    public class Transaction : StripeEntity<Transaction>, IHasId, IHasObject
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
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The amount of the Transaction.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public TransactionAmount Amount { get; set; }

        /// <summary>
        /// The delta to the FinancialAccount's balance. The balance_impact for the Transaction is
        /// equal to sum of its TransactionEntries that have <c>effective_at</c>s in the past.
        /// </summary>
        [JsonProperty("balance_impact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_impact")]
#endif
        public TransactionBalanceImpact BalanceImpact { get; set; }

        /// <summary>
        /// Open Enum. A descriptive category used to classify the Transaction.
        /// One of: <c>adjustment</c>, <c>currency_conversion</c>, <c>inbound_transfer</c>,
        /// <c>outbound_payment</c>, <c>outbound_transfer</c>, <c>received_credit</c>,
        /// <c>received_debit</c>, <c>return</c>, or <c>stripe_fee</c>.
        /// </summary>
        [JsonProperty("category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category")]
#endif
        public string Category { get; set; }

        /// <summary>
        /// Time at which the object was created. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Indicates the FinancialAccount affected by this Transaction.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Details about the Flow object that created the Transaction.
        /// </summary>
        [JsonProperty("flow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow")]
#endif
        public TransactionFlow Flow { get; set; }

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
        /// Closed Enum. Current status of the Transaction. A Transaction is <c>pending</c> if
        /// either <c>balance_impact.inbound_pending</c> or <c>balance_impact.outbound_pending</c>
        /// is non-zero. A Transaction is <c>posted</c> if only <c>balance_impact.available</c> is
        /// non-zero. A Transaction is <c>void</c> if there is no balance impact. <c>posted</c> and
        /// <c>void</c> are terminal states, and no additional entries will be added to the
        /// Transaction.
        /// One of: <c>pending</c>, <c>posted</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Timestamps for when the Transaction transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_transitions")]
#endif
        public TransactionStatusTransitions StatusTransitions { get; set; }
    }
}
