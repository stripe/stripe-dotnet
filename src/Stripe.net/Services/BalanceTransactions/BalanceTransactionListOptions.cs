// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceTransactionListOptions : ListOptions
    {
        /// <summary>
        /// Only return transactions that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return transactions in a certain currency. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// For automatic Stripe payouts only, only returns transactions that were paid out on the
        /// specified payout ID.
        /// </summary>
        [JsonProperty("payout")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout")]
#endif
        public string Payout { get; set; }

        /// <summary>
        /// Only returns transactions associated with the given object.
        /// </summary>
        [JsonProperty("source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
#endif
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
        /// <c>payout</c>, <c>payout_cancel</c>, <c>payout_failure</c>,
        /// <c>payout_minimum_balance_hold</c>, <c>payout_minimum_balance_release</c>,
        /// <c>refund</c>, <c>refund_failure</c>, <c>reserve_transaction</c>, <c>reserved_funds</c>,
        /// <c>reserve_hold</c>, <c>reserve_release</c>, <c>stripe_fee</c>, <c>stripe_fx_fee</c>,
        /// <c>stripe_balance_payment_debit</c>, <c>stripe_balance_payment_debit_reversal</c>,
        /// <c>tax_fee</c>, <c>topup</c>, <c>topup_reversal</c>, <c>transfer</c>,
        /// <c>transfer_cancel</c>, <c>transfer_failure</c>, or <c>transfer_refund</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
