// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WorkflowRunStatusTransitions : StripeEntity<WorkflowRunStatusTransitions>
    {
        /// <summary>
        /// When the Workflow Run failed.
        /// </summary>
        [JsonProperty("failed_at")]
        [STJS.JsonPropertyName("failed_at")]
        public DateTime? FailedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// When the Workflow Run was started.
        /// </summary>
        [JsonProperty("started_at")]
        [STJS.JsonPropertyName("started_at")]
        public DateTime? StartedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// When the Workflow Run succeeded.
        /// </summary>
        [JsonProperty("succeeded_at")]
        [STJS.JsonPropertyName("succeeded_at")]
        public DateTime? SucceededAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
