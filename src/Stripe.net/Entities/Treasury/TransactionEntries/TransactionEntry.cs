// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// TransactionEntries represent individual units of money movements within a single <a
    /// href="https://stripe.com/docs/api#transactions">Transaction</a>.
    /// </summary>
    public class TransactionEntry : StripeEntity<TransactionEntry>, IHasId, IHasObject
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
        /// Change to a FinancialAccount's balance.
        /// </summary>
        [JsonProperty("balance_impact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_impact")]
#endif

        public TransactionEntryBalanceImpact BalanceImpact { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
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
        /// When the TransactionEntry will impact the FinancialAccount's balance.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The FinancialAccount associated with this object.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif

        public string FinancialAccount { get; set; }

        /// <summary>
        /// Token of the flow associated with the TransactionEntry.
        /// </summary>
        [JsonProperty("flow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow")]
#endif

        public string Flow { get; set; }

        /// <summary>
        /// Details of the flow associated with the TransactionEntry.
        /// </summary>
        [JsonProperty("flow_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow_details")]
#endif

        public TransactionEntryFlowDetails FlowDetails { get; set; }

        /// <summary>
        /// Type of the flow associated with the TransactionEntry.
        /// One of: <c>credit_reversal</c>, <c>debit_reversal</c>, <c>inbound_transfer</c>,
        /// <c>issuing_authorization</c>, <c>other</c>, <c>outbound_payment</c>,
        /// <c>outbound_transfer</c>, <c>received_credit</c>, or <c>received_debit</c>.
        /// </summary>
        [JsonProperty("flow_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow_type")]
#endif

        public string FlowType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        #region Expandable Transaction

        /// <summary>
        /// (ID of the Transaction)
        /// The Transaction associated with this object.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string TransactionId
        {
            get => this.InternalTransaction?.Id;
            set => this.InternalTransaction = SetExpandableFieldId(value, this.InternalTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// The Transaction associated with this object.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Transaction Transaction
        {
            get => this.InternalTransaction?.ExpandedObject;
            set => this.InternalTransaction = SetExpandableFieldObject(value, this.InternalTransaction);
        }

        [JsonProperty("transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Transaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Transaction>))]
#endif

        internal ExpandableField<Transaction> InternalTransaction { get; set; }
        #endregion

        /// <summary>
        /// The specific money movement that generated the TransactionEntry.
        /// One of: <c>credit_reversal</c>, <c>credit_reversal_posting</c>, <c>debit_reversal</c>,
        /// <c>inbound_transfer</c>, <c>inbound_transfer_return</c>,
        /// <c>issuing_authorization_hold</c>, <c>issuing_authorization_release</c>, <c>other</c>,
        /// <c>outbound_payment</c>, <c>outbound_payment_cancellation</c>,
        /// <c>outbound_payment_failure</c>, <c>outbound_payment_posting</c>,
        /// <c>outbound_payment_return</c>, <c>outbound_transfer</c>,
        /// <c>outbound_transfer_cancellation</c>, <c>outbound_transfer_failure</c>,
        /// <c>outbound_transfer_posting</c>, <c>outbound_transfer_return</c>,
        /// <c>received_credit</c>, or <c>received_debit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
