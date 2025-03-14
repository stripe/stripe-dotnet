// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventReasonAutomationAction : StripeEntity<EventReasonAutomationAction>
    {
        [JsonProperty("stripe_send_webhook_custom_event")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_send_webhook_custom_event")]
#endif
        public EventReasonAutomationActionStripeSendWebhookCustomEvent StripeSendWebhookCustomEvent { get; set; }

        /// <summary>
        /// The trigger name of the automation that triggered this action. Please visit <a
        /// href="https://docs.stripe.com/billing/automations#choose-a-trigger">Revenue and
        /// retention automations</a> for all possible trigger names.
        /// </summary>
        [JsonProperty("trigger")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trigger")]
#endif
        public string Trigger { get; set; }

        /// <summary>
        /// The type of the <c>automation_action</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
