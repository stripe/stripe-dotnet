// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Balance transactions represent funds moving through your Stripe account. Stripe creates
    /// them for every type of transaction that enters or leaves your Stripe account balance.
    ///
    /// Related guide: <a
    /// href="https://docs.stripe.com/reports/balance-transaction-types">Balance transaction
    /// types</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BalanceTransaction : StripeEntity<BalanceTransaction>, IHasId, IHasObject
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
        /// Gross amount of this transaction (in cents (or local equivalent)). A positive value
        /// represents funds charged to another party, and a negative value represents funds sent to
        /// another party.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The date that the transaction's net funds become available in the Stripe balance.
        /// </summary>
        [JsonProperty("available_on")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("available_on")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime AvailableOn { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The balance that this transaction impacts.
        /// One of: <c>fee_credits</c>, <c>issuing</c>, <c>payments</c>,
        /// <c>refund_and_dispute_prefunding</c>, <c>risk_reserved</c>, <c>settlement_reserved</c>,
        /// or <c>transit</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("balance_type")]
        [STJS.JsonPropertyName("balance_type")]
        public string BalanceType { get; set; }

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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The exchange rate used for this transaction, if applicable. Multiplying the source
        /// <c>amount</c> by the <c>exchange_rate</c> gives the destination <c>amount</c>, both in
        /// their currencies' smallest units. For example, <c>1000</c> EUR cents converts to
        /// <c>1234</c> USD cents at <c>1.234</c>. For a zero-decimal currency such as JPY,
        /// <c>1000</c> JPY converts to <c>640</c> USD cents (6.40 USD) at <c>0.64</c>, equivalent
        /// to <c>0.0064</c> USD per JPY. For JPY to USD, the API multiplier is 100 times the
        /// whole-unit rate because JPY amounts use yen and USD amounts use cents.
        /// </summary>
        [JsonProperty("exchange_rate")]
        [STJS.JsonPropertyName("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Fees (in cents (or local equivalent)) paid for this transaction. Represented as a
        /// positive integer when assessed.
        /// </summary>
        [JsonProperty("fee")]
        [STJS.JsonPropertyName("fee")]
        public long Fee { get; set; }

        /// <summary>
        /// Detailed breakdown of fees (in cents (or local equivalent)) paid for this transaction.
        /// </summary>
        [JsonProperty("fee_details")]
        [STJS.JsonPropertyName("fee_details")]
        public List<BalanceTransactionFeeDetail> FeeDetails { get; set; }

        /// <summary>
        /// Net impact to a Stripe balance (in cents (or local equivalent)). A positive value
        /// represents incrementing a Stripe balance, and a negative value decrementing a Stripe
        /// balance. You can calculate the net impact of a transaction on a balance by <c>amount</c>
        /// - <c>fee</c>.
        /// </summary>
        [JsonProperty("net")]
        [STJS.JsonPropertyName("net")]
        public long Net { get; set; }

        /// <summary>
        /// Learn more about how <a
        /// href="https://stripe.com/docs/reports/reporting-categories">reporting categories</a> can
        /// help you understand balance transactions from an accounting perspective.
        /// </summary>
        [JsonProperty("reporting_category")]
        [STJS.JsonPropertyName("reporting_category")]
        public string ReportingCategory { get; set; }

        #region Expandable Source

        /// <summary>
        /// (ID of the IBalanceTransactionSource)
        /// This transaction relates to the Stripe object.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string SourceId
        {
            get => this.InternalSource?.Id;
            set => this.InternalSource = SetExpandableFieldId(value, this.InternalSource);
        }

        /// <summary>
        /// (Expanded)
        /// This transaction relates to the Stripe object.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public IBalanceTransactionSource Source
        {
            get => this.InternalSource?.ExpandedObject;
            set => this.InternalSource = SetExpandableFieldObject(value, this.InternalSource);
        }

        [JsonProperty("source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IBalanceTransactionSource>))]
        [STJS.JsonPropertyName("source")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<IBalanceTransactionSource>))]
        internal ExpandableField<IBalanceTransactionSource> InternalSource { get; set; }
        #endregion

        /// <summary>
        /// The transaction's net funds status in the Stripe balance, which are either
        /// <c>available</c> or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Transaction type: <c>tax_fund</c>, <c>adjustment</c>, <c>advance</c>,
        /// <c>advance_funding</c>, <c>anticipation_repayment</c>, <c>application_fee</c>,
        /// <c>application_fee_refund</c>, <c>charge</c>, <c>climate_order_purchase</c>,
        /// <c>climate_order_refund</c>, <c>connect_collection_transfer</c>, <c>contribution</c>,
        /// <c>inbound_transfer</c>, <c>inbound_transfer_reversal</c>,
        /// <c>issuing_authorization_hold</c>, <c>issuing_authorization_release</c>,
        /// <c>issuing_dispute</c>, <c>issuing_dispute_provisional_credit</c>,
        /// <c>issuing_dispute_provisional_credit_reversal</c>, <c>issuing_transaction</c>,
        /// <c>obligation_outbound</c>, <c>obligation_reversal_inbound</c>, <c>payment</c>,
        /// <c>payment_failure_refund</c>, <c>payment_network_reserve_hold</c>,
        /// <c>payment_network_reserve_release</c>, <c>payment_refund</c>, <c>payment_reversal</c>,
        /// <c>payment_unreconciled</c>, <c>payout</c>, <c>payout_cancel</c>, <c>payout_failure</c>,
        /// <c>payout_minimum_balance_hold</c>, <c>payout_minimum_balance_release</c>,
        /// <c>refund</c>, <c>refund_failure</c>, <c>reserve_transaction</c>, <c>reserved_funds</c>,
        /// <c>reserve_hold</c>, <c>reserve_release</c>, <c>stripe_fee</c>, <c>stripe_fx_fee</c>,
        /// <c>stripe_balance_payment_debit</c>, <c>stripe_balance_payment_debit_reversal</c>,
        /// <c>tax_fee</c>, <c>topup</c>, <c>topup_reversal</c>, <c>transfer</c>,
        /// <c>transfer_cancel</c>, <c>transfer_failure</c>, <c>transfer_refund</c>, or
        /// <c>fee_credit_funding</c>. Learn more about <a
        /// href="https://stripe.com/docs/reports/balance-transaction-types">balance transaction
        /// types and what they represent</a>. To classify transactions for accounting purposes,
        /// consider <c>reporting_category</c> instead.
        /// One of: <c>adjustment</c>, <c>advance</c>, <c>advance_funding</c>,
        /// <c>anticipation_repayment</c>, <c>application_fee</c>, <c>application_fee_refund</c>,
        /// <c>charge</c>, <c>climate_order_purchase</c>, <c>climate_order_refund</c>,
        /// <c>connect_collection_transfer</c>, <c>contribution</c>, <c>fee_credit_funding</c>,
        /// <c>inbound_transfer</c>, <c>inbound_transfer_reversal</c>,
        /// <c>issuing_authorization_hold</c>, <c>issuing_authorization_release</c>,
        /// <c>issuing_dispute</c>, <c>issuing_dispute_provisional_credit</c>,
        /// <c>issuing_dispute_provisional_credit_reversal</c>, <c>issuing_transaction</c>,
        /// <c>obligation_outbound</c>, <c>obligation_reversal_inbound</c>, <c>payment</c>,
        /// <c>payment_failure_refund</c>, <c>payment_network_reserve_hold</c>,
        /// <c>payment_network_reserve_release</c>, <c>payment_refund</c>, <c>payment_reversal</c>,
        /// <c>payment_unreconciled</c>, <c>payout</c>, <c>payout_cancel</c>, <c>payout_failure</c>,
        /// <c>payout_minimum_balance_hold</c>, <c>payout_minimum_balance_release</c>,
        /// <c>refund</c>, <c>refund_failure</c>, <c>reserve_hold</c>, <c>reserve_release</c>,
        /// <c>reserve_transaction</c>, <c>reserved_funds</c>, <c>stripe_balance_payment_debit</c>,
        /// <c>stripe_balance_payment_debit_reversal</c>, <c>stripe_fee</c>, <c>stripe_fx_fee</c>,
        /// <c>tax_fee</c>, <c>tax_fund</c>, <c>topup</c>, <c>topup_reversal</c>, <c>transfer</c>,
        /// <c>transfer_cancel</c>, <c>transfer_failure</c>, or <c>transfer_refund</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
