namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Transfer : StripeEntity<Transfer>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Amount in %s to be transferred.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Amount in %s reversed (can be less than the amount attribute on the transfer if a
        /// partial reversal was issued).
        /// </summary>
        [JsonProperty("amount_reversed")]
        public long AmountReversed { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// Balance transaction that describes the impact of this transfer on your account balance.
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// Balance transaction that describes the impact of this transfer on your account balance.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// Time that this record of the transfer was first created.
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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// ID of the Stripe account the transfer was sent to.
        /// </summary>
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Stripe account the transfer was sent to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion

        #region Expandable DestinationPayment

        /// <summary>
        /// (ID of the Charge)
        /// If the destination is a Stripe account, this will be the ID of the payment that the
        /// destination account received for the transfer.
        /// </summary>
        [JsonIgnore]
        public string DestinationPaymentId
        {
            get => this.InternalDestinationPayment?.Id;
            set => this.InternalDestinationPayment = SetExpandableFieldId(value, this.InternalDestinationPayment);
        }

        /// <summary>
        /// (Expanded)
        /// If the destination is a Stripe account, this will be the ID of the payment that the
        /// destination account received for the transfer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Charge DestinationPayment
        {
            get => this.InternalDestinationPayment?.ExpandedObject;
            set => this.InternalDestinationPayment = SetExpandableFieldObject(value, this.InternalDestinationPayment);
        }

        [JsonProperty("destination_payment")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalDestinationPayment { get; set; }
        #endregion

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
        /// A list of reversals that have been applied to the transfer.
        /// </summary>
        [JsonProperty("reversals")]
        public StripeList<TransferReversal> Reversals { get; set; }

        /// <summary>
        /// Whether the transfer has been fully reversed. If the transfer is only partially
        /// reversed, this attribute will still be false.
        /// </summary>
        [JsonProperty("reversed")]
        public bool Reversed { get; set; }

        #region Expandable SourceTransaction

        /// <summary>
        /// (ID of the Charge)
        /// ID of the charge or payment that was used to fund the transfer. If null, the transfer
        /// was funded from the available balance.
        /// </summary>
        [JsonIgnore]
        public string SourceTransactionId
        {
            get => this.InternalSourceTransaction?.Id;
            set => this.InternalSourceTransaction = SetExpandableFieldId(value, this.InternalSourceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the charge or payment that was used to fund the transfer. If null, the transfer
        /// was funded from the available balance.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Charge SourceTransaction
        {
            get => this.InternalSourceTransaction?.ExpandedObject;
            set => this.InternalSourceTransaction = SetExpandableFieldObject(value, this.InternalSourceTransaction);
        }

        [JsonProperty("source_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalSourceTransaction { get; set; }
        #endregion

        /// <summary>
        /// The source balance this transfer came from. One of <c>card</c>, <c>fpx</c>, or
        /// <c>bank_account</c>.
        /// </summary>
        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://stripe.com/docs/connect/charges-transfers#transfer-options">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
