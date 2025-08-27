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
        /// One of: <c>adjustment</c>, <c>currency_conversion</c>, <c>inbound_transfer</c>,
        /// <c>outbound_payment</c>, <c>outbound_transfer</c>, <c>received_credit</c>,
        /// <c>received_debit</c>, <c>return</c>, or <c>stripe_fee</c>.
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
