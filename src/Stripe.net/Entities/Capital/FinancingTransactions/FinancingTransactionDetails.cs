// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancingTransactionDetails : StripeEntity<FinancingTransactionDetails>
    {
        /// <summary>
        /// The advance amount being repaid, paid out, or reversed in minor units.
        /// </summary>
        [JsonProperty("advance_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("advance_amount")]
#endif
        public long AdvanceAmount { get; set; }

        /// <summary>
        /// The currency of the financing transaction.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The fee amount being repaid, paid out, or reversed in minor units.
        /// </summary>
        [JsonProperty("fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fee_amount")]
#endif
        public long FeeAmount { get; set; }

        /// <summary>
        /// The linked payment for the transaction. This field only applies to financing
        /// transactions of type <c>paydown</c> and reason <c>automatic_withholding</c>.
        /// </summary>
        [JsonProperty("linked_payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("linked_payment")]
#endif
        public string LinkedPayment { get; set; }

        /// <summary>
        /// The reason for the financing transaction (if applicable).
        /// One of: <c>automatic_withholding</c>, <c>automatic_withholding_refund</c>,
        /// <c>collection</c>, <c>collection_failure</c>, <c>financing_cancellation</c>,
        /// <c>refill</c>, <c>requested_by_user</c>, or <c>user_initiated</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        /// <summary>
        /// The reversed transaction. This field only applies to financing transactions of type
        /// <c>reversal</c>.
        /// </summary>
        [JsonProperty("reversed_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reversed_transaction")]
#endif
        public string ReversedTransaction { get; set; }

        /// <summary>
        /// The advance and fee amount being repaid, paid out, or reversed in minor units.
        /// </summary>
        [JsonProperty("total_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_amount")]
#endif
        public long TotalAmount { get; set; }

        /// <summary>
        /// This is an object representing a linked transaction on a Capital Financing Transaction.
        /// </summary>
        [JsonProperty("transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
#endif
        public FinancingTransactionDetailsTransaction Transaction { get; set; }
    }
}
