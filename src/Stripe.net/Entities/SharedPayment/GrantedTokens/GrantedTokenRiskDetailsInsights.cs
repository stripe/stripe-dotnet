// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenRiskDetailsInsights : StripeEntity<GrantedTokenRiskDetailsInsights>
    {
        /// <summary>
        /// Bot risk insight (score: Float, recommended_action).
        /// </summary>
        [JsonProperty("bot")]
        [STJS.JsonPropertyName("bot")]
        public GrantedTokenRiskDetailsInsightsBot Bot { get; set; }

        /// <summary>
        /// Card issuer decline risk insight (score: Float, recommended_action).
        /// </summary>
        [JsonProperty("card_issuer_decline")]
        [STJS.JsonPropertyName("card_issuer_decline")]
        public GrantedTokenRiskDetailsInsightsCardIssuerDecline CardIssuerDecline { get; set; }

        /// <summary>
        /// Card testing risk insight (score: Float, recommended_action).
        /// </summary>
        [JsonProperty("card_testing")]
        [STJS.JsonPropertyName("card_testing")]
        public GrantedTokenRiskDetailsInsightsCardTesting CardTesting { get; set; }

        /// <summary>
        /// Fraudulent dispute risk insight (score: Integer, recommended_action).
        /// </summary>
        [JsonProperty("fraudulent_dispute")]
        [STJS.JsonPropertyName("fraudulent_dispute")]
        public GrantedTokenRiskDetailsInsightsFraudulentDispute FraudulentDispute { get; set; }

        /// <summary>
        /// Stolen card risk insight (score: Integer, recommended_action).
        /// </summary>
        [JsonProperty("stolen_card")]
        [STJS.JsonPropertyName("stolen_card")]
        public GrantedTokenRiskDetailsInsightsStolenCard StolenCard { get; set; }
    }
}
