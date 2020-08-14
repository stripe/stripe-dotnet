namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class BalanceTransaction : StripeEntity<BalanceTransaction>, IHasId, IHasObject
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
        /// Gross amount of the transaction, in %s.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The date the transaction's net funds will become available in the Stripe balance.
        /// </summary>
        [JsonProperty("available_on")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime AvailableOn { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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

        /// <summary>
        /// The exchange rate used, if applicable, for this transaction. Specifically, if money was
        /// converted from currency A to currency B, then the <c>amount</c> in currency A, times
        /// <c>exchange_rate</c>, would be the <c>amount</c> in currency B. For example, suppose you
        /// charged a customer 10.00 EUR. Then the PaymentIntent's <c>amount</c> would be
        /// <c>1000</c> and <c>currency</c> would be <c>eur</c>. Suppose this was converted into
        /// 12.34 USD in your Stripe account. Then the BalanceTransaction's <c>amount</c> would be
        /// <c>1234</c>, <c>currency</c> would be <c>usd</c>, and <c>exchange_rate</c> would be
        /// <c>1.234</c>.
        /// </summary>
        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Fees (in %s) paid for this transaction.
        /// </summary>
        [JsonProperty("fee")]
        public long Fee { get; set; }

        /// <summary>
        /// Detailed breakdown of fees (in %s) paid for this transaction.
        /// </summary>
        [JsonProperty("fee_details")]
        public List<BalanceTransactionFeeDetail> FeeDetails { get; set; }

        /// <summary>
        /// Net amount of the transaction, in %s.
        /// </summary>
        [JsonProperty("net")]
        public long Net { get; set; }

        /// <summary>
        /// <a href="https://stripe.com/docs/reports/reporting-categories">Learn more</a> about how
        /// reporting categories can help you understand balance transactions from an accounting
        /// perspective.
        /// </summary>
        [JsonProperty("reporting_category")]
        public string ReportingCategory { get; set; }

        #region Expandable Source

        /// <summary>
        /// (ID of the IBalanceTransactionSource)
        /// The Stripe object to which this transaction is related.
        /// </summary>
        [JsonIgnore]
        public string SourceId
        {
            get => this.InternalSource?.Id;
            set => this.InternalSource = SetExpandableFieldId(value, this.InternalSource);
        }

        /// <summary>
        /// (Expanded)
        /// The Stripe object to which this transaction is related.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public IBalanceTransactionSource Source
        {
            get => this.InternalSource?.ExpandedObject;
            set => this.InternalSource = SetExpandableFieldObject(value, this.InternalSource);
        }

        [JsonProperty("source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IBalanceTransactionSource>))]
        internal ExpandableField<IBalanceTransactionSource> InternalSource { get; set; }
        #endregion

        /// <summary>
        /// If the transaction's net funds are available in the Stripe balance yet. Either
        /// <c>available</c> or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Transaction type: <c>adjustment</c>, <c>advance</c>, <c>advance_funding</c>,
        /// <c>anticipation_repayment</c>, <c>application_fee</c>, <c>application_fee_refund</c>,
        /// <c>charge</c>, <c>connect_collection_transfer</c>, <c>issuing_authorization_hold</c>,
        /// <c>issuing_authorization_release</c>, <c>issuing_dispute</c>,
        /// <c>issuing_transaction</c>, <c>payment</c>, <c>payment_failure_refund</c>,
        /// <c>payment_refund</c>, <c>payout</c>, <c>payout_cancel</c>, <c>payout_failure</c>,
        /// <c>refund</c>, <c>refund_failure</c>, <c>reserve_transaction</c>, <c>reserved_funds</c>,
        /// <c>stripe_fee</c>, <c>stripe_fx_fee</c>, <c>tax_fee</c>, <c>topup</c>,
        /// <c>topup_reversal</c>, <c>transfer</c>, <c>transfer_cancel</c>, <c>transfer_failure</c>,
        /// or <c>transfer_refund</c>. <a
        /// href="https://stripe.com/docs/reports/balance-transaction-types">Learn more</a> about
        /// balance transaction types and what they represent. If you are looking to classify
        /// transactions for accounting purposes, you might want to consider
        /// <c>reporting_category</c> instead.
        /// One of: <c>adjustment</c>, <c>advance</c>, <c>advance_funding</c>,
        /// <c>anticipation_repayment</c>, <c>application_fee</c>, <c>application_fee_refund</c>,
        /// <c>charge</c>, <c>connect_collection_transfer</c>, <c>issuing_authorization_hold</c>,
        /// <c>issuing_authorization_release</c>, <c>issuing_dispute</c>,
        /// <c>issuing_transaction</c>, <c>payment</c>, <c>payment_failure_refund</c>,
        /// <c>payment_refund</c>, <c>payout</c>, <c>payout_cancel</c>, <c>payout_failure</c>,
        /// <c>refund</c>, <c>refund_failure</c>, <c>reserve_transaction</c>, <c>reserved_funds</c>,
        /// <c>stripe_fee</c>, <c>stripe_fx_fee</c>, <c>tax_fee</c>, <c>topup</c>,
        /// <c>topup_reversal</c>, <c>transfer</c>, <c>transfer_cancel</c>, <c>transfer_failure</c>,
        /// or <c>transfer_refund</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
