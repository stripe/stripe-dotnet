// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// TransactionEntries represent individual units of money movements within a single <a
    /// href="https://api.stripe.com#transactions">Transaction</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionEntry : StripeEntity<TransactionEntry>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Change to a FinancialAccount's balance.
        /// </summary>
        [JsonProperty("balance_impact")]
        [STJS.JsonPropertyName("balance_impact")]
        public TransactionEntryBalanceImpact BalanceImpact { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// When the TransactionEntry will impact the FinancialAccount's balance.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("effective_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The FinancialAccount associated with this object.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Token of the flow associated with the TransactionEntry.
        /// </summary>
        [JsonProperty("flow")]
        [STJS.JsonPropertyName("flow")]
        public string Flow { get; set; }

        /// <summary>
        /// Details of the flow associated with the TransactionEntry.
        /// </summary>
        [JsonProperty("flow_details")]
        [STJS.JsonPropertyName("flow_details")]
        public TransactionEntryFlowDetails FlowDetails { get; set; }

        /// <summary>
        /// Type of the flow associated with the TransactionEntry.
        /// One of: <c>credit_reversal</c>, <c>debit_reversal</c>, <c>inbound_transfer</c>,
        /// <c>issuing_authorization</c>, <c>other</c>, <c>outbound_payment</c>,
        /// <c>outbound_transfer</c>, <c>received_credit</c>, or <c>received_debit</c>.
        /// </summary>
        [JsonProperty("flow_type")]
        [STJS.JsonPropertyName("flow_type")]
        public string FlowType { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Transaction

        /// <summary>
        /// (ID of the Transaction)
        /// The Transaction associated with this object.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Transaction Transaction
        {
            get => this.InternalTransaction?.ExpandedObject;
            set => this.InternalTransaction = SetExpandableFieldObject(value, this.InternalTransaction);
        }

        [JsonProperty("transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transaction>))]
        [STJS.JsonPropertyName("transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Transaction>))]
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
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
