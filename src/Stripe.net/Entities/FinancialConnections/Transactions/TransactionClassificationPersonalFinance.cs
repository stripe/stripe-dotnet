// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionClassificationPersonalFinance : StripeEntity<TransactionClassificationPersonalFinance>
    {
        /// <summary>
        /// Stripe's confidence in this classification.
        /// One of: <c>high</c>, <c>low</c>, <c>medium</c>, or <c>very_high</c>.
        /// </summary>
        [JsonProperty("confidence_level")]
        [STJS.JsonPropertyName("confidence_level")]
        public string ConfidenceLevel { get; set; }

        /// <summary>
        /// The detailed category label for this transaction.
        /// </summary>
        [JsonProperty("detailed_label")]
        [STJS.JsonPropertyName("detailed_label")]
        public string DetailedLabel { get; set; }

        /// <summary>
        /// The primary category label for this transaction.
        /// </summary>
        [JsonProperty("primary_label")]
        [STJS.JsonPropertyName("primary_label")]
        public string PrimaryLabel { get; set; }
    }
}
