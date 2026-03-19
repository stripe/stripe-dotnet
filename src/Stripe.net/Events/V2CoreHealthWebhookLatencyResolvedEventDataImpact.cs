// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreHealthWebhookLatencyResolvedEventDataImpact : StripeEntity<V2CoreHealthWebhookLatencyResolvedEventDataImpact>
    {
        /// <summary>
        /// The number of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests")]
        [STJS.JsonPropertyName("impacted_requests")]
        public long ImpactedRequests { get; set; }
    }
}
