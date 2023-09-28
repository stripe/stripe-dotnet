// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class EventReason : StripeEntity<EventReason>
    {
        [JsonProperty("automation_action")]
        public EventReasonAutomationAction AutomationAction { get; set; }

        [JsonProperty("request")]
        public EventReasonRequest Request { get; set; }

        /// <summary>
        /// The type of the reason for the event.
        /// One of: <c>automation_action</c>, or <c>request</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
