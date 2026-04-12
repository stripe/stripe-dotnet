// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuedTokenRiskDetailsInsights : StripeEntity<IssuedTokenRiskDetailsInsights>
    {
        /// <summary>
        /// Bot risk insight.
        /// </summary>
        [JsonProperty("bot")]
        [STJS.JsonPropertyName("bot")]
        public IssuedTokenRiskDetailsInsightsBot Bot { get; set; }

        /// <summary>
        /// Card issuer decline risk insight.
        /// </summary>
        [JsonProperty("card_issuer_decline")]
        [STJS.JsonPropertyName("card_issuer_decline")]
        public IssuedTokenRiskDetailsInsightsCardIssuerDecline CardIssuerDecline { get; set; }

        /// <summary>
        /// Card testing risk insight.
        /// </summary>
        [JsonProperty("card_testing")]
        [STJS.JsonPropertyName("card_testing")]
        public IssuedTokenRiskDetailsInsightsCardTesting CardTesting { get; set; }

        /// <summary>
        /// Fraudulent dispute risk insight.
        /// </summary>
        [JsonProperty("fraudulent_dispute")]
        [STJS.JsonPropertyName("fraudulent_dispute")]
        public IssuedTokenRiskDetailsInsightsFraudulentDispute FraudulentDispute { get; set; }

        /// <summary>
        /// Stolen card risk insight.
        /// </summary>
        [JsonProperty("stolen_card")]
        [STJS.JsonPropertyName("stolen_card")]
        public IssuedTokenRiskDetailsInsightsStolenCard StolenCard { get; set; }
    }
}
