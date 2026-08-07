// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionEnrichmentsMerchant : StripeEntity<TransactionEnrichmentsMerchant>
    {
        /// <summary>
        /// Stripe's confidence in the enriched merchant name.
        /// One of: <c>high</c>, <c>low</c>, <c>medium</c>, or <c>very_high</c>.
        /// </summary>
        [JsonProperty("confidence_level")]
        [STJS.JsonPropertyName("confidence_level")]
        public string ConfidenceLevel { get; set; }

        /// <summary>
        /// The normalized merchant name for this transaction.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
