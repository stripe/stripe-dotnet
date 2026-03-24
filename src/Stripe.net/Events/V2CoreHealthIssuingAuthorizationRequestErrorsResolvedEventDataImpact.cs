// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventDataImpact : StripeEntity<V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventDataImpact>
    {
        /// <summary>
        /// Estimated aggregated amount for the approved requests.
        /// </summary>
        [JsonProperty("approved_amount")]
        [STJS.JsonPropertyName("approved_amount")]
        public V2.Amount ApprovedAmount { get; set; }

        /// <summary>
        /// The number of approved requests which are impacted.
        /// </summary>
        [JsonProperty("approved_impacted_requests")]
        [STJS.JsonPropertyName("approved_impacted_requests")]
        public long? ApprovedImpactedRequests { get; set; }

        /// <summary>
        /// Estimated aggregated amount for the declined requests.
        /// </summary>
        [JsonProperty("declined_amount")]
        [STJS.JsonPropertyName("declined_amount")]
        public V2.Amount DeclinedAmount { get; set; }

        /// <summary>
        /// The number of declined requests which are impacted.
        /// </summary>
        [JsonProperty("declined_impacted_requests")]
        [STJS.JsonPropertyName("declined_impacted_requests")]
        public long? DeclinedImpactedRequests { get; set; }
    }
}
