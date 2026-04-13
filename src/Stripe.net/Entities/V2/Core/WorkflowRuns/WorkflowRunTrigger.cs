// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WorkflowRunTrigger : StripeEntity<WorkflowRunTrigger>
    {
        /// <summary>
        /// Which type of trigger this is.
        /// One of: <c>event_trigger</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The Workflow Run was launched when Stripe emitted a certain event.
        /// </summary>
        [JsonProperty("event_trigger")]
        [STJS.JsonPropertyName("event_trigger")]
        public WorkflowRunTriggerEventTrigger EventTrigger { get; set; }

        /// <summary>
        /// The Workflow Run was launched through a direct call, using either the Dashboard or the
        /// Stripe API.
        /// </summary>
        [JsonProperty("manual")]
        [STJS.JsonPropertyName("manual")]
        public WorkflowRunTriggerManual Manual { get; set; }
    }
}
