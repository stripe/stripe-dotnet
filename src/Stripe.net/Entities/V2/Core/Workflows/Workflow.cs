// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Stripe Workflow is a sequence of actions, like Stripe API calls, that are taken in
    /// response to an initiating trigger. A trigger can be a Stripe API event, or a manual
    /// invocation.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Workflow : StripeEntity<Workflow>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique ID of the Workflow.
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
        /// When the Workflow was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Workflow description.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Whether this Workflow is active, inactive, or in some other state. Only active Workflows
        /// may be invoked.
        /// One of: <c>active</c>, <c>archived</c>, <c>draft</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Under what conditions will this Workflow launch.
        /// </summary>
        [JsonProperty("triggers")]
        [STJS.JsonPropertyName("triggers")]
        public List<WorkflowTrigger> Triggers { get; set; }
    }
}
