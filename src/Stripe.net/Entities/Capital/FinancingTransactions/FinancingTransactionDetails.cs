// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;

    public class FinancingTransactionDetails : StripeEntity<FinancingTransactionDetails>
    {
        /// <summary>
        /// The advance amount being repaid, paid out, or reversed in minor units.
        /// </summary>
        [JsonProperty("advance_amount")]
        public long AdvanceAmount { get; set; }

        /// <summary>
        /// The currency of the financing transaction.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The fee amount being repaid, paid out, or reversed in minor units.
        /// </summary>
        [JsonProperty("fee_amount")]
        public long FeeAmount { get; set; }

        /// <summary>
        /// The linked payment for the transaction. This field only applies to financing
        /// transactions of type <c>paydown</c> and reason <c>automatic_withholding</c>.
        /// </summary>
        [JsonProperty("linked_payment")]
        public string LinkedPayment { get; set; }

        /// <summary>
        /// The reason for the financing transaction (if applicable).
        /// One of: <c>automatic_withholding</c>, <c>automatic_withholding_refund</c>,
        /// <c>collection</c>, <c>collection_failure</c>, <c>financing_cancellation</c>,
        /// <c>refill</c>, <c>requested_by_user</c>, or <c>user_initiated</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The reversed transaction. This field only applies to financing transactions of type
        /// <c>reversal</c>.
        /// </summary>
        [JsonProperty("reversed_transaction")]
        public string ReversedTransaction { get; set; }

        /// <summary>
        /// The advance and fee amount being repaid, paid out, or reversed in minor units.
        /// </summary>
        [JsonProperty("total_amount")]
        public long TotalAmount { get; set; }
    }
}
