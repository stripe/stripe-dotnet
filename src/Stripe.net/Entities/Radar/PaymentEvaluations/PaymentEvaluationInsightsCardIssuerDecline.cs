// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationInsightsCardIssuerDecline : StripeEntity<PaymentEvaluationInsightsCardIssuerDecline>
    {
        /// <summary>
        /// Stripe Radar's evaluation of the likelihood that the payment will be declined by the
        /// card issuer. Scores range from 0 to 100, with higher values indicating a higher
        /// likelihood of decline.
        /// </summary>
        [JsonProperty("model_score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("model_score")]
#endif
        public decimal ModelScore { get; set; }

        /// <summary>
        /// Recommended action based on the model score. Possible values are <c>block</c> and
        /// <c>continue</c>.
        /// One of: <c>block</c>, or <c>continue</c>.
        /// </summary>
        [JsonProperty("recommended_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recommended_action")]
#endif
        public string RecommendedAction { get; set; }
    }
}
