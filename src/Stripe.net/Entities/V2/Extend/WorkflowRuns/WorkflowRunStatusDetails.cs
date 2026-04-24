// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WorkflowRunStatusDetails : StripeEntity<WorkflowRunStatusDetails>
    {
        /// <summary>
        /// Details about the Workflow Run's transition into the FAILED state.
        /// </summary>
        [JsonProperty("failed")]
        [STJS.JsonPropertyName("failed")]
        public WorkflowRunStatusDetailsFailed Failed { get; set; }

        /// <summary>
        /// Details about the Workflow Run's transition in to the STARTED state.
        /// </summary>
        [JsonProperty("started")]
        [STJS.JsonPropertyName("started")]
        public WorkflowRunStatusDetailsStarted Started { get; set; }

        /// <summary>
        /// Details about the Workflow Run's transition into the SUCCEEDED state.
        /// </summary>
        [JsonProperty("succeeded")]
        [STJS.JsonPropertyName("succeeded")]
        public WorkflowRunStatusDetailsSucceeded Succeeded { get; set; }
    }
}
