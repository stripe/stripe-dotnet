// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionClassification : StripeEntity<TransactionClassification>
    {
        [JsonProperty("financial_activity")]
        [STJS.JsonPropertyName("financial_activity")]
        public TransactionClassificationFinancialActivity FinancialActivity { get; set; }

        [JsonProperty("money_movement")]
        [STJS.JsonPropertyName("money_movement")]
        public TransactionClassificationMoneyMovement MoneyMovement { get; set; }

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
