// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An execution of a Workflow in response to a triggering event.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WorkflowRun : StripeEntity<WorkflowRun>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique ID of the Workflow Run.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// When the Workflow Run was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The current Workflow Run execution status.
        /// One of: <c>failed</c>, <c>started</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Details about the Workflow Run's status transitions.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public WorkflowRunStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Summary information about the Workflow Run's status transitions.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public WorkflowRunStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// A record of the trigger that launched this Workflow Run.
        /// </summary>
        [JsonProperty("trigger")]
        [STJS.JsonPropertyName("trigger")]
        public WorkflowRunTrigger Trigger { get; set; }

        /// <summary>
        /// The Workflow this Run belongs to.
        /// </summary>
        [JsonProperty("workflow")]
        [STJS.JsonPropertyName("workflow")]
        public string Workflow { get; set; }
    }
}
