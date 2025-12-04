// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventReasonRequestClient : StripeEntity<EventReasonRequestClient>
    {
        /// <summary>
        /// The type of the client.
        /// One of: <c>api_key</c>, <c>dashboard_user</c>, or <c>stripe_action</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// API key that triggered the event.
        /// </summary>
        [JsonProperty("api_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("api_key")]
#endif
        public EventReasonRequestClientApiKey ApiKey { get; set; }

        /// <summary>
        /// Dashboard user that triggered the event.
        /// </summary>
        [JsonProperty("dashboard_user")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dashboard_user")]
#endif
        public EventReasonRequestClientDashboardUser DashboardUser { get; set; }

        /// <summary>
        /// Stripe action that triggered the event.
        /// </summary>
        [JsonProperty("stripe_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_action")]
#endif
        public Dictionary<string, object> StripeAction { get; set; }
    }
}
