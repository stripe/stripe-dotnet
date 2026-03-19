// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
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
        [STJS.JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Indicates the FinancialAccount affected by this Transaction.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Details about the Flow object that created the Transaction.
        /// </summary>
        [JsonProperty("flow")]
        [STJS.JsonPropertyName("flow")]
        public TransactionEntryTransactionDetailsFlow Flow { get; set; }
    }
}
