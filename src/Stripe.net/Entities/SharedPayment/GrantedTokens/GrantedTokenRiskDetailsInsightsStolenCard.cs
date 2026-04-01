// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenRiskDetailsInsightsStolenCard : StripeEntity<GrantedTokenRiskDetailsInsightsStolenCard>
    {
        /// <summary>
        /// Recommended action for this insight.
        /// </summary>
        [JsonProperty("recommended_action")]
        [STJS.JsonPropertyName("recommended_action")]
        public string RecommendedAction { get; set; }

        /// <summary>
        /// Risk score for this insight (integer).
        /// </summary>
        [JsonProperty("score")]
        [STJS.JsonPropertyName("score")]
        public long Score { get; set; }
    }
}
