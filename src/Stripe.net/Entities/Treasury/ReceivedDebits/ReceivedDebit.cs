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
    /// ReceivedDebits represent funds pulled from a <a
    /// href="https://stripe.com/docs/api#financial_accounts">FinancialAccount</a>. These are
    /// not initiated from the FinancialAccount.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class ReceivedDebit : StripeEntity<ReceivedDebit>, IHasId, IHasObject
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
        /// Amount (in cents) transferred.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Reason for the failure. A ReceivedDebit might fail because the FinancialAccount doesn't
        /// have sufficient funds, is closed, or is frozen.
        /// One of: <c>account_closed</c>, <c>account_frozen</c>, <c>insufficient_funds</c>,
        /// <c>international_transaction</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("failure_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_code")]
#endif
        public string FailureCode { get; set; }

        /// <summary>
        /// The FinancialAccount that funds were pulled from.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/treasury/moving-money/regulatory-receipts">hosted
        /// transaction receipt</a> URL that is provided when money movement is considered regulated
        /// under Stripe's money transmission licenses.
        /// </summary>
        [JsonProperty("hosted_regulatory_receipt_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_regulatory_receipt_url")]
#endif
        public string HostedRegulatoryReceiptUrl { get; set; }

        [JsonProperty("initiating_payment_method_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("initiating_payment_method_details")]
#endif
        public ReceivedDebitInitiatingPaymentMethodDetails InitiatingPaymentMethodDetails { get; set; }

        [JsonProperty("linked_flows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("linked_flows")]
#endif
        public ReceivedDebitLinkedFlows LinkedFlows { get; set; }

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
        /// The network used for the ReceivedDebit.
        /// One of: <c>ach</c>, <c>card</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }

        /// <summary>
        /// Details specific to the money movement rails.
        /// </summary>
        [JsonProperty("network_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_details")]
#endif
        public ReceivedDebitNetworkDetails NetworkDetails { get; set; }

        /// <summary>
        /// Details describing when a ReceivedDebit might be reversed.
        /// </summary>
        [JsonProperty("reversal_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reversal_details")]
#endif
        public ReceivedDebitReversalDetails ReversalDetails { get; set; }

        /// <summary>
        /// Status of the ReceivedDebit. ReceivedDebits are created with a status of either
        /// <c>succeeded</c> (approved) or <c>failed</c> (declined). The failure reason can be found
        /// under the <c>failure_code</c>.
        /// One of: <c>failed</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

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
        [JsonConverter(typeof(ExpandableFieldConverter<Transaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Transaction>))]
#endif
        internal ExpandableField<Transaction> InternalTransaction { get; set; }
        #endregion
    }
}
