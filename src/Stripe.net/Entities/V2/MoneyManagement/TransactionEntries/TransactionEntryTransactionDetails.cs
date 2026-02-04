// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionEntryTransactionDetails : StripeEntity<TransactionEntryTransactionDetails>
    {
        /// <summary>
        /// Closed Enum for now, and will be turned into an Open Enum soon. A descriptive category
        /// used to classify the Transaction.
        /// One of: <c>adjustment</c>, <c>advance</c>, <c>anticipation_repayment</c>,
        /// <c>balance_transfer</c>, <c>charge</c>, <c>charge_failure</c>,
        /// <c>climate_order_purchase</c>, <c>climate_order_refund</c>,
        /// <c>connect_collection_transfer</c>, <c>connect_reserved_funds</c>, <c>contribution</c>,
        /// <c>currency_conversion</c>, <c>dispute_reversal</c>, <c>financing_paydown</c>,
        /// <c>financing_paydown_reversal</c>, <c>inbound_transfer</c>,
        /// <c>inbound_transfer_reversal</c>, <c>issuing_dispute</c>,
        /// <c>issuing_dispute_fraud_liability_debit</c>, <c>issuing_dispute_provisional_credit</c>,
        /// <c>issuing_dispute_provisional_credit_reversal</c>, <c>minimum_balance_hold</c>,
        /// <c>network_cost</c>, <c>obligation</c>, <c>outbound_payment</c>,
        /// <c>outbound_payment_reversal</c>, <c>outbound_transfer</c>,
        /// <c>outbound_transfer_reversal</c>, <c>partial_capture_reversal</c>,
        /// <c>payment_network_reserved_funds</c>, <c>platform_earning</c>,
        /// <c>platform_earning_refund</c>, <c>platform_fee</c>, <c>received_credit</c>,
        /// <c>received_credit_reversal</c>, <c>received_debit</c>, <c>received_debit_reversal</c>,
        /// <c>refund_failure</c>, <c>return</c>, <c>risk_reserved_funds</c>,
        /// <c>stripe_balance_payment_debit</c>, <c>stripe_balance_payment_debit_reversal</c>,
        /// <c>stripe_fee</c>, <c>stripe_fee_tax</c>, <c>transfer_reversal</c>, or
        /// <c>unreconciled_customer_funds</c>.
        /// </summary>
        [JsonProperty("category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category")]
#endif
        public string Category { get; set; }

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
        public TransactionEntryTransactionDetailsFlow Flow { get; set; }
    }
}
