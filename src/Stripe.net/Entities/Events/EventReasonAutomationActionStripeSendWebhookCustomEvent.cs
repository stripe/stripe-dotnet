// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventReasonAutomationActionStripeSendWebhookCustomEvent : StripeEntity<EventReasonAutomationActionStripeSendWebhookCustomEvent>
    {
        /// <summary>
        /// Set of key-value pairs attached to the action when creating an Automation.
        /// </summary>
        [JsonProperty("custom_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_data")]
#endif
        public Dictionary<string, string> CustomData { get; set; }
    }
}
