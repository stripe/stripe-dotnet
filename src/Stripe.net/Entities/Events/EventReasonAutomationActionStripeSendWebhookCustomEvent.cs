// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EventReasonAutomationActionStripeSendWebhookCustomEvent : StripeEntity<EventReasonAutomationActionStripeSendWebhookCustomEvent>
    {
        /// <summary>
        /// Set of key-value pairs attached to the action when creating an Automation.
        /// </summary>
        [JsonProperty("custom_data")]
        public Dictionary<string, string> CustomData { get; set; }
    }
}
