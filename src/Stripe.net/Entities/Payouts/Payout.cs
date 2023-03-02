// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A <c>Payout</c> object is created when you receive funds from Stripe, or when you
    /// initiate a payout to either a bank account or debit card of a <a
    /// href="https://stripe.com/docs/connect/bank-debit-card-payouts">connected Stripe
    /// account</a>. You can retrieve individual payouts, as well as list all payouts. Payouts
    /// are made on <a href="https://stripe.com/docs/connect/manage-payout-schedule">varying
    /// schedules</a>, depending on your country and industry.
    ///
    /// Related guide: <a href="https://stripe.com/docs/payouts">Receiving Payouts</a>.
    /// </summary>
    public class Payout : StripeEntity<Payout>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Amount (in %s) to be transferred to your bank account or debit card.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Date the payout is expected to arrive in the bank. This factors in delays like weekends
        /// or bank holidays.
        /// </summary>
        [JsonProperty("arrival_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ArrivalDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Returns <c>true</c> if the payout was created by an <a
        /// href="https://stripe.com/docs/payouts#payout-schedule">automated payout schedule</a>,
        /// and <c>false</c> if it was <a
        /// href="https://stripe.com/docs/payouts#manual-payouts">requested manually</a>.
        /// </summary>
        [JsonProperty("automatic")]
        public bool Automatic { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// ID of the balance transaction that describes the impact of this payout on your account
        /// balance.
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the balance transaction that describes the impact of this payout on your account
        /// balance.
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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the IExternalAccount)
        /// ID of the bank account or card the payout was sent to.
        /// </summary>
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the bank account or card the payout was sent to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public IExternalAccount Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<IExternalAccount>))]
        internal ExpandableField<IExternalAccount> InternalDestination { get; set; }
        #endregion

        #region Expandable FailureBalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// If the payout failed or was canceled, this will be the ID of the balance transaction
        /// that reversed the initial balance transaction, and puts the funds from the failed payout
        /// back in your balance.
        /// </summary>
        [JsonIgnore]
        public string FailureBalanceTransactionId
        {
            get => this.InternalFailureBalanceTransaction?.Id;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldId(value, this.InternalFailureBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// If the payout failed or was canceled, this will be the ID of the balance transaction
        /// that reversed the initial balance transaction, and puts the funds from the failed payout
        /// back in your balance.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public BalanceTransaction FailureBalanceTransaction
        {
            get => this.InternalFailureBalanceTransaction?.ExpandedObject;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldObject(value, this.InternalFailureBalanceTransaction);
        }

        [JsonProperty("failure_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalFailureBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// Error code explaining reason for payout failure if available. See <a
        /// href="https://stripe.com/docs/api#payout_failures">Types of payout failures</a> for a
        /// list of failure codes.
        /// </summary>
        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// Message to user further explaining reason for payout failure if available.
        /// </summary>
        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

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
        /// The method used to send this payout, which can be <c>standard</c> or <c>instant</c>.
        /// <c>instant</c> is only supported for payouts to debit cards. (See <a
        /// href="https://stripe.com/blog/instant-payouts-for-marketplaces">Instant payouts for
        /// marketplaces</a> for more information.).
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        #region Expandable OriginalPayout

        /// <summary>
        /// (ID of the Payout)
        /// If the payout reverses another, this is the ID of the original payout.
        /// </summary>
        [JsonIgnore]
        public string OriginalPayoutId
        {
            get => this.InternalOriginalPayout?.Id;
            set => this.InternalOriginalPayout = SetExpandableFieldId(value, this.InternalOriginalPayout);
        }

        /// <summary>
        /// (Expanded)
        /// If the payout reverses another, this is the ID of the original payout.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Payout OriginalPayout
        {
            get => this.InternalOriginalPayout?.ExpandedObject;
            set => this.InternalOriginalPayout = SetExpandableFieldObject(value, this.InternalOriginalPayout);
        }

        [JsonProperty("original_payout")]
        [JsonConverter(typeof(ExpandableFieldConverter<Payout>))]
        internal ExpandableField<Payout> InternalOriginalPayout { get; set; }
        #endregion

        /// <summary>
        /// If <c>completed</c>, the <a
        /// href="https://stripe.com/docs/api/balance_transactions/list#balance_transaction_list-payout">Balance
        /// Transactions API</a> may be used to list all Balance Transactions that were paid out in
        /// this payout.
        /// One of: <c>completed</c>, <c>in_progress</c>, or <c>not_applicable</c>.
        /// </summary>
        [JsonProperty("reconciliation_status")]
        public string ReconciliationStatus { get; set; }

        #region Expandable ReversedBy

        /// <summary>
        /// (ID of the Payout)
        /// If the payout was reversed, this is the ID of the payout that reverses this payout.
        /// </summary>
        [JsonIgnore]
        public string ReversedById
        {
            get => this.InternalReversedBy?.Id;
            set => this.InternalReversedBy = SetExpandableFieldId(value, this.InternalReversedBy);
        }

        /// <summary>
        /// (Expanded)
        /// If the payout was reversed, this is the ID of the payout that reverses this payout.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Payout ReversedBy
        {
            get => this.InternalReversedBy?.ExpandedObject;
            set => this.InternalReversedBy = SetExpandableFieldObject(value, this.InternalReversedBy);
        }

        [JsonProperty("reversed_by")]
        [JsonConverter(typeof(ExpandableFieldConverter<Payout>))]
        internal ExpandableField<Payout> InternalReversedBy { get; set; }
        #endregion

        /// <summary>
        /// The source balance this payout came from. One of <c>card</c>, <c>fpx</c>, or
        /// <c>bank_account</c>.
        /// </summary>
        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// Extra information about a payout to be displayed on the user's bank statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Current status of the payout: <c>paid</c>, <c>pending</c>, <c>in_transit</c>,
        /// <c>canceled</c> or <c>failed</c>. A payout is <c>pending</c> until it is submitted to
        /// the bank, when it becomes <c>in_transit</c>. The status then changes to <c>paid</c> if
        /// the transaction goes through, or to <c>failed</c> or <c>canceled</c> (within 5 business
        /// days). Some failed payouts may initially show as <c>paid</c> but then change to
        /// <c>failed</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Can be <c>bank_account</c> or <c>card</c>.
        /// One of: <c>bank_account</c>, or <c>card</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
