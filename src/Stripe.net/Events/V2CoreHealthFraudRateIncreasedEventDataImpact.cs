// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthFraudRateIncreasedEventDataImpact : StripeEntity<V2CoreHealthFraudRateIncreasedEventDataImpact>
    {
        /// <summary>
        /// Fraud attack type.
        /// One of: <c>spike</c>, or <c>sustained_attack</c>.
        /// </summary>
        [JsonProperty("attack_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("attack_type")]
#endif
        public string AttackType { get; set; }

        /// <summary>
        /// The number of impacted requests which are detected.
        /// </summary>
        [JsonProperty("impacted_requests")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impacted_requests")]
#endif
        public long ImpactedRequests { get; set; }

        /// <summary>
        /// Estimated aggregated amount for the impacted requests.
        /// </summary>
        [JsonProperty("realized_fraud_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("realized_fraud_amount")]
#endif
        public V2.Amount RealizedFraudAmount { get; set; }
    }
}
