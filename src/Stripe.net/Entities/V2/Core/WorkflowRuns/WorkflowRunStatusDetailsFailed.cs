// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WorkflowRunStatusDetailsFailed : StripeEntity<WorkflowRunStatusDetailsFailed>
    {
        /// <summary>
        /// If this Workflow Run failed during the processing of an action step, the step
        /// identifier.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// Category of the failure result.
        /// </summary>
        [JsonProperty("error_code")]
        [STJS.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Optional details about the failure result.
        /// </summary>
        [JsonProperty("error_message")]
        [STJS.JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }
    }
}
