// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionClassification : StripeEntity<TransactionClassification>
    {
        /// <summary>
        /// Money movement classification labels for this transaction.
        /// </summary>
        [JsonProperty("money_movement")]
        [STJS.JsonPropertyName("money_movement")]
        public TransactionClassificationMoneyMovement MoneyMovement { get; set; }

        /// <summary>
        /// Personal finance classification labels for this transaction.
        /// </summary>
        [JsonProperty("personal_finance")]
        [STJS.JsonPropertyName("personal_finance")]
        public TransactionClassificationPersonalFinance PersonalFinance { get; set; }

        /// <summary>
        /// The taxonomy type for this classification entry.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
