// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventDataImpact : StripeEntity<V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventDataImpact>
    {
        /// <summary>
        /// Estimated aggregated amount for the approved requests.
        /// </summary>
        [JsonProperty("approved_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("approved_amount")]
#endif
        public V2.Amount ApprovedAmount { get; set; }

        /// <summary>
        /// The number of approved requests which are impacted.
        /// </summary>
        [JsonProperty("approved_impacted_requests")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("approved_impacted_requests")]
#endif
        public long ApprovedImpactedRequests { get; set; }

        /// <summary>
        /// Estimated aggregated amount for the declined requests.
        /// </summary>
        [JsonProperty("declined_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("declined_amount")]
#endif
        public V2.Amount DeclinedAmount { get; set; }

        /// <summary>
        /// The number of declined requests which are impacted.
        /// </summary>
        [JsonProperty("declined_impacted_requests")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("declined_impacted_requests")]
#endif
        public long DeclinedImpactedRequests { get; set; }
    }
}
