// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class BalanceTransactionListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return transactions in a certain currency. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// For automatic Stripe payouts only, only returns transactions that were paid out on the
        /// specified payout ID.
        /// </summary>
        [JsonProperty("payout")]
        public string Payout { get; set; }

        /// <summary>
        /// Only returns the original transaction.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Only returns transactions of the given type. One of: <c>adjustment</c>, <c>advance</c>,
        /// <c>advance_funding</c>, <c>anticipation_repayment</c>, <c>application_fee</c>,
        /// <c>application_fee_refund</c>, <c>charge</c>, <c>climate_order_purchase</c>,
        /// <c>climate_order_refund</c>, <c>connect_collection_transfer</c>, <c>contribution</c>,
        /// <c>issuing_authorization_hold</c>, <c>issuing_authorization_release</c>,
        /// <c>issuing_dispute</c>, <c>issuing_transaction</c>, <c>obligation_outbound</c>,
        /// <c>obligation_reversal_inbound</c>, <c>payment</c>, <c>payment_failure_refund</c>,
        /// <c>payment_network_reserve_hold</c>, <c>payment_network_reserve_release</c>,
        /// <c>payment_refund</c>, <c>payment_reversal</c>, <c>payment_unreconciled</c>,
        /// <c>payout</c>, <c>payout_cancel</c>, <c>payout_failure</c>, <c>refund</c>,
        /// <c>refund_failure</c>, <c>reserve_transaction</c>, <c>reserved_funds</c>,
        /// <c>stripe_fee</c>, <c>stripe_fx_fee</c>, <c>tax_fee</c>, <c>topup</c>,
        /// <c>topup_reversal</c>, <c>transfer</c>, <c>transfer_cancel</c>, <c>transfer_failure</c>,
        /// or <c>transfer_refund</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
