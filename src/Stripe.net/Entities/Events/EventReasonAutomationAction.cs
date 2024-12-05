// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class EventReasonAutomationAction : StripeEntity<EventReasonAutomationAction>
    {
        [JsonProperty("stripe_send_webhook_custom_event")]
        public EventReasonAutomationActionStripeSendWebhookCustomEvent StripeSendWebhookCustomEvent { get; set; }

        /// <summary>
        /// The trigger name of the automation that triggered this action. Please visit <a
        /// href="https://docs.stripe.com/billing/automations#choose-a-trigger">Revenue and
        /// retention automations</a> for all possible trigger names.
        /// </summary>
        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        /// <summary>
        /// The type of the <c>automation_action</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
