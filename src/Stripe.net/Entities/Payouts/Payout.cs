// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A <c>Payout</c> object is created when you receive funds from Stripe, or when you
    /// initiate a payout to either a bank account or debit card of a <a
    /// href="https://stripe.com/docs/connect/bank-debit-card-payouts">connected Stripe
    /// account</a>. You can retrieve individual payouts, and list all payouts. Payouts are made
    /// on <a href="https://stripe.com/docs/connect/manage-payout-schedule">varying
    /// schedules</a>, depending on your country and industry.
    ///
    /// Related guide: <a href="https://stripe.com/docs/payouts">Receiving payouts</a>.
    /// </summary>
    public class Payout : StripeEntity<Payout>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// The amount (in cents (or local equivalent)) that transfers to your bank account or debit
        /// card.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        #region Expandable ApplicationFee

        /// <summary>
        /// (ID of the ApplicationFee)
        /// The application fee (if any) for the payout. <a
        /// href="https://stripe.com/docs/connect/instant-payouts#monetization-and-fees">See the
        /// Connect documentation</a> for details.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ApplicationFeeId
        {
            get => this.InternalApplicationFee?.Id;
            set => this.InternalApplicationFee = SetExpandableFieldId(value, this.InternalApplicationFee);
        }

        /// <summary>
        /// (Expanded)
        /// The application fee (if any) for the payout. <a
        /// href="https://stripe.com/docs/connect/instant-payouts#monetization-and-fees">See the
        /// Connect documentation</a> for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public ApplicationFee ApplicationFee
        {
            get => this.InternalApplicationFee?.ExpandedObject;
            set => this.InternalApplicationFee = SetExpandableFieldObject(value, this.InternalApplicationFee);
        }

        [JsonProperty("application_fee")]
        [JsonConverter(typeof(ExpandableFieldConverter<ApplicationFee>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("application_fee")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<ApplicationFee>))]
#endif
        internal ExpandableField<ApplicationFee> InternalApplicationFee { get; set; }
        #endregion

        /// <summary>
        /// The amount of the application fee (if any) requested for the payout. <a
        /// href="https://stripe.com/docs/connect/instant-payouts#monetization-and-fees">See the
        /// Connect documentation</a> for details.
        /// </summary>
        [JsonProperty("application_fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_amount")]
#endif
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Date that you can expect the payout to arrive in the bank. This factors in delays to
        /// account for weekends or bank holidays.
        /// </summary>
        [JsonProperty("arrival_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("arrival_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ArrivalDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Returns <c>true</c> if the payout is created by an <a
        /// href="https://stripe.com/docs/payouts#payout-schedule">automated payout schedule</a> and
        /// <c>false</c> if it's <a href="https://stripe.com/docs/payouts#manual-payouts">requested
        /// manually</a>.
        /// </summary>
        [JsonProperty("automatic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic")]
#endif
        public bool Automatic { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// ID of the balance transaction that describes the impact of this payout on your account
        /// balance.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BalanceTransaction>))]
#endif
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

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

        #region Expandable Destination

        /// <summary>
        /// (ID of the IExternalAccount)
        /// ID of the bank account or card the payout is sent to.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the bank account or card the payout is sent to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public IExternalAccount Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<IExternalAccount>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("destination")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<IExternalAccount>))]
#endif
        internal ExpandableField<IExternalAccount> InternalDestination { get; set; }
        #endregion

        #region Expandable FailureBalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// If the payout fails or cancels, this is the ID of the balance transaction that reverses
        /// the initial balance transaction and returns the funds from the failed payout back in
        /// your balance.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string FailureBalanceTransactionId
        {
            get => this.InternalFailureBalanceTransaction?.Id;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldId(value, this.InternalFailureBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// If the payout fails or cancels, this is the ID of the balance transaction that reverses
        /// the initial balance transaction and returns the funds from the failed payout back in
        /// your balance.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public BalanceTransaction FailureBalanceTransaction
        {
            get => this.InternalFailureBalanceTransaction?.ExpandedObject;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldObject(value, this.InternalFailureBalanceTransaction);
        }

        [JsonProperty("failure_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("failure_balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BalanceTransaction>))]
#endif
        internal ExpandableField<BalanceTransaction> InternalFailureBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// Error code that provides a reason for a payout failure, if available. View our <a
        /// href="https://stripe.com/docs/api#payout_failures">list of failure codes</a>.
        /// </summary>
        [JsonProperty("failure_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_code")]
#endif
        public string FailureCode { get; set; }

        /// <summary>
        /// Message that provides the reason for a payout failure, if available.
        /// </summary>
        [JsonProperty("failure_message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_message")]
#endif
        public string FailureMessage { get; set; }

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
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The method used to send this payout, which can be <c>standard</c> or <c>instant</c>.
        /// <c>instant</c> is supported for payouts to debit cards and bank accounts in certain
        /// countries. Learn more about <a
        /// href="https://stripe.com/docs/payouts/instant-payouts-banks">bank support for Instant
        /// Payouts</a>.
        /// </summary>
        [JsonProperty("method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("method")]
#endif
        public string Method { get; set; }

        #region Expandable OriginalPayout

        /// <summary>
        /// (ID of the Payout)
        /// If the payout reverses another, this is the ID of the original payout.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Payout OriginalPayout
        {
            get => this.InternalOriginalPayout?.ExpandedObject;
            set => this.InternalOriginalPayout = SetExpandableFieldObject(value, this.InternalOriginalPayout);
        }

        [JsonProperty("original_payout")]
        [JsonConverter(typeof(ExpandableFieldConverter<Payout>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("original_payout")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Payout>))]
#endif
        internal ExpandableField<Payout> InternalOriginalPayout { get; set; }
        #endregion

        /// <summary>
        /// If <c>completed</c>, you can use the <a
        /// href="https://stripe.com/docs/api/balance_transactions/list#balance_transaction_list-payout">Balance
        /// Transactions API</a> to list all balance transactions that are paid out in this payout.
        /// One of: <c>completed</c>, <c>in_progress</c>, or <c>not_applicable</c>.
        /// </summary>
        [JsonProperty("reconciliation_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reconciliation_status")]
#endif
        public string ReconciliationStatus { get; set; }

        #region Expandable ReversedBy

        /// <summary>
        /// (ID of the Payout)
        /// If the payout reverses, this is the ID of the payout that reverses this payout.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ReversedById
        {
            get => this.InternalReversedBy?.Id;
            set => this.InternalReversedBy = SetExpandableFieldId(value, this.InternalReversedBy);
        }

        /// <summary>
        /// (Expanded)
        /// If the payout reverses, this is the ID of the payout that reverses this payout.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Payout ReversedBy
        {
            get => this.InternalReversedBy?.ExpandedObject;
            set => this.InternalReversedBy = SetExpandableFieldObject(value, this.InternalReversedBy);
        }

        [JsonProperty("reversed_by")]
        [JsonConverter(typeof(ExpandableFieldConverter<Payout>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("reversed_by")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Payout>))]
#endif
        internal ExpandableField<Payout> InternalReversedBy { get; set; }
        #endregion

        /// <summary>
        /// The source balance this payout came from, which can be one of the following:
        /// <c>card</c>, <c>fpx</c>, or <c>bank_account</c>.
        /// </summary>
        [JsonProperty("source_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_type")]
#endif
        public string SourceType { get; set; }

        /// <summary>
        /// Extra information about a payout that displays on the user's bank statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Current status of the payout: <c>paid</c>, <c>pending</c>, <c>in_transit</c>,
        /// <c>canceled</c> or <c>failed</c>. A payout is <c>pending</c> until it's submitted to the
        /// bank, when it becomes <c>in_transit</c>. The status changes to <c>paid</c> if the
        /// transaction succeeds, or to <c>failed</c> or <c>canceled</c> (within 5 business days).
        /// Some payouts that fail might initially show as <c>paid</c>, then change to
        /// <c>failed</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// A value that generates from the beneficiary's bank that allows users to track payouts
        /// with their bank. Banks might call this a "reference number" or something similar.
        /// </summary>
        [JsonProperty("trace_id")]
        public PayoutTraceId TraceId { get; set; }

        /// <summary>
        /// Can be <c>bank_account</c> or <c>card</c>.
        /// One of: <c>bank_account</c>, or <c>card</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
