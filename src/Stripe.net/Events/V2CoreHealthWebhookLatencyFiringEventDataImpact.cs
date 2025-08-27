// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthWebhookLatencyFiringEventDataImpact : StripeEntity<V2CoreHealthWebhookLatencyFiringEventDataImpact>
    {
        /// <summary>
        /// The number of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impacted_requests")]
#endif
        public long ImpactedRequests { get; set; }
    }
}
