// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// As a <a href="https://stripe.com/docs/issuing">card issuer</a>, you can dispute
    /// transactions that the cardholder does not recognize, suspects to be fraudulent, or has
    /// other issues with.
    ///
    /// Related guide: <a href="https://stripe.com/docs/issuing/purchases/disputes">Issuing
    /// disputes</a>.
    /// </summary>
    public class Dispute : StripeEntity<Dispute>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Disputed amount in the card's currency and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// Usually the amount of the <c>transaction</c>, but can differ (usually because of
        /// currency fluctuation).
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// List of balance transactions associated with the dispute.
        /// </summary>
        [JsonProperty("balance_transactions")]
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The currency the <c>transaction</c> was made in.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("evidence")]
        public DisputeEvidence Evidence { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The enum that describes the dispute loss outcome. If the dispute is not lost, this field
        /// will be absent. New enum values may be added in the future, so be sure to handle unknown
        /// values.
        /// One of: <c>cardholder_authentication_issuer_liability</c>,
        /// <c>eci5_token_transaction_with_tavv</c>, <c>excess_disputes_in_timeframe</c>,
        /// <c>has_not_met_the_minimum_dispute_amount_requirements</c>,
        /// <c>invalid_duplicate_dispute</c>, <c>invalid_incorrect_amount_dispute</c>,
        /// <c>invalid_no_authorization</c>, <c>invalid_use_of_disputes</c>,
        /// <c>merchandise_delivered_or_shipped</c>, <c>merchandise_or_service_as_described</c>,
        /// <c>not_cancelled</c>, <c>other</c>, <c>refund_issued</c>,
        /// <c>submitted_beyond_allowable_time_limit</c>, <c>transaction_3ds_required</c>,
        /// <c>transaction_approved_after_prior_fraud_dispute</c>, <c>transaction_authorized</c>,
        /// <c>transaction_electronically_read</c>,
        /// <c>transaction_qualifies_for_visa_easy_payment_service</c>, or
        /// <c>transaction_unattended</c>.
        /// </summary>
        [JsonProperty("loss_reason")]
        public string LossReason { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Current status of the dispute.
        /// One of: <c>expired</c>, <c>lost</c>, <c>submitted</c>, <c>unsubmitted</c>, or
        /// <c>won</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable Transaction

        /// <summary>
        /// (ID of the Transaction)
        /// The transaction being disputed.
        /// </summary>
        [JsonIgnore]
        public string TransactionId
        {
            get => this.InternalTransaction?.Id;
            set => this.InternalTransaction = SetExpandableFieldId(value, this.InternalTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// The transaction being disputed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Transaction Transaction
        {
            get => this.InternalTransaction?.ExpandedObject;
            set => this.InternalTransaction = SetExpandableFieldObject(value, this.InternalTransaction);
        }

        [JsonProperty("transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transaction>))]
        internal ExpandableField<Transaction> InternalTransaction { get; set; }
        #endregion

        /// <summary>
        /// <a href="https://stripe.com/docs/api/treasury">Treasury</a> details related to this
        /// dispute if it was created on a [FinancialAccount](/docs/api/treasury/financial_accounts.
        /// </summary>
        [JsonProperty("treasury")]
        public DisputeTreasury Treasury { get; set; }
    }
}
