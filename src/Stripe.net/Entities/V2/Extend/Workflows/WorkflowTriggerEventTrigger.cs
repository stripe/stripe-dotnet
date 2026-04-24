// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WorkflowTriggerEventTrigger : StripeEntity<WorkflowTriggerEventTrigger>
    {
        /// <summary>
        /// Specifies which accounts' events will trigger this Workflow.
        /// </summary>
        [JsonProperty("events_from")]
        [STJS.JsonPropertyName("events_from")]
        public List<string> EventsFrom { get; set; }

        /// <summary>
        /// The Stripe event type that will trigger this Workflow.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
