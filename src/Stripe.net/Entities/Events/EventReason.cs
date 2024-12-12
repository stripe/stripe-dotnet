// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventReason : StripeEntity<EventReason>
    {
        [JsonProperty("automation_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automation_action")]
#endif
        public EventReasonAutomationAction AutomationAction { get; set; }

        [JsonProperty("request")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request")]
#endif
        public EventReasonRequest Request { get; set; }

        /// <summary>
        /// The type of the reason for the event.
        /// One of: <c>automation_action</c>, or <c>request</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
