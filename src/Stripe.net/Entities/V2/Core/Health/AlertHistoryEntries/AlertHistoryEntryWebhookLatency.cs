// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertHistoryEntryWebhookLatency : StripeEntity<AlertHistoryEntryWebhookLatency>
    {
        /// <summary>
        /// The number of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests")]
        [STJS.JsonPropertyName("impacted_requests")]
        public long ImpactedRequests { get; set; }
    }
}
