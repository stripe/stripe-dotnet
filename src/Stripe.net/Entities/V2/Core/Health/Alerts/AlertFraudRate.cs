// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertFraudRate : StripeEntity<AlertFraudRate>
    {
        /// <summary>
        /// Fraud attack type.
        /// One of: <c>spike</c>, or <c>sustained_attack</c>.
        /// </summary>
        [JsonProperty("attack_type")]
        [STJS.JsonPropertyName("attack_type")]
        public string AttackType { get; set; }

        /// <summary>
        /// The number of impacted requests which are detected.
        /// </summary>
        [JsonProperty("impacted_requests")]
        [STJS.JsonPropertyName("impacted_requests")]
        public long ImpactedRequests { get; set; }

        /// <summary>
        /// Estimated aggregated amount for the impacted requests.
        /// </summary>
        [JsonProperty("realized_fraud_amount")]
        [STJS.JsonPropertyName("realized_fraud_amount")]
        public V2.Amount RealizedFraudAmount { get; set; }
    }
}
