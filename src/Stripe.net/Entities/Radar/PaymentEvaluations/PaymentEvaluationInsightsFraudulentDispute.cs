// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationInsightsFraudulentDispute : StripeEntity<PaymentEvaluationInsightsFraudulentDispute>
    {
        /// <summary>
        /// Recommended action based on the risk score. Possible values are <c>block</c> and
        /// <c>continue</c>.
        /// One of: <c>block</c>, or <c>continue</c>.
        /// </summary>
        [JsonProperty("recommended_action")]
        [STJS.JsonPropertyName("recommended_action")]
        public string RecommendedAction { get; set; }

        /// <summary>
        /// Stripe Radar’s evaluation of the risk level of the payment. Possible values for
        /// evaluated payments are between 0 and 100, with higher scores indicating higher risk.
        /// </summary>
        [JsonProperty("risk_score")]
        [STJS.JsonPropertyName("risk_score")]
        public long RiskScore { get; set; }
    }
}
