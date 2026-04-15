// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EventReasonRequestClient : StripeEntity<EventReasonRequestClient>
    {
        /// <summary>
        /// API key that triggered the event.
        /// </summary>
        [JsonProperty("api_key")]
        [STJS.JsonPropertyName("api_key")]
        public EventReasonRequestClientApiKey ApiKey { get; set; }

        /// <summary>
        /// Dashboard user that triggered the event.
        /// </summary>
        [JsonProperty("dashboard_user")]
        [STJS.JsonPropertyName("dashboard_user")]
        public EventReasonRequestClientDashboardUser DashboardUser { get; set; }

        /// <summary>
        /// Stripe action that triggered the event.
        /// </summary>
        [JsonProperty("stripe_action")]
        [STJS.JsonPropertyName("stripe_action")]
        public EventReasonRequestClientStripeAction StripeAction { get; set; }

        /// <summary>
        /// The type of the client.
        /// One of: <c>api_key</c>, <c>dashboard_user</c>, or <c>stripe_action</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
