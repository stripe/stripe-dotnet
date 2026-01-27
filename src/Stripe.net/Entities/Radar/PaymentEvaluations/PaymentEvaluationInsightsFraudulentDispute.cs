// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationInsightsFraudulentDispute : StripeEntity<PaymentEvaluationInsightsFraudulentDispute>
    {
        /// <summary>
        /// Recommended action based on the risk score. Possible values are <c>block</c> and
        /// <c>continue</c>.
        /// One of: <c>block</c>, or <c>continue</c>.
        /// </summary>
        [JsonProperty("recommended_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recommended_action")]
#endif
        public string RecommendedAction { get; set; }

        /// <summary>
        /// Stripe Radar’s evaluation of the risk level of the payment. Possible values for
        /// evaluated payments are between 0 and 100, with higher scores indicating higher risk.
        /// </summary>
        [JsonProperty("risk_score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("risk_score")]
#endif
        public long RiskScore { get; set; }
    }
}
