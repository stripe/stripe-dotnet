// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApprovalRequestStatusDetails : StripeEntity<ApprovalRequestStatusDetails>
    {
        /// <summary>
        /// Deprecated: use requires_execution status instead.
        /// </summary>
        [JsonProperty("approved")]
        [STJS.JsonPropertyName("approved")]
        public ApprovalRequestStatusDetailsApproved Approved { get; set; }

        /// <summary>
        /// Deprecated: use canceled status instead.
        /// </summary>
        [JsonProperty("canceled")]
        [STJS.JsonPropertyName("canceled")]
        public ApprovalRequestStatusDetailsCanceled Canceled { get; set; }

        /// <summary>
        /// Deprecated: use failed status instead.
        /// </summary>
        [JsonProperty("execution_failed")]
        [STJS.JsonPropertyName("execution_failed")]
        public ApprovalRequestStatusDetailsExecutionFailed ExecutionFailed { get; set; }

        /// <summary>
        /// Deprecated: use requires_execution status instead.
        /// </summary>
        [JsonProperty("execution_started")]
        [STJS.JsonPropertyName("execution_started")]
        public ApprovalRequestStatusDetailsExecutionStarted ExecutionStarted { get; set; }

        /// <summary>
        /// Deprecated: use succeeded status instead.
        /// </summary>
        [JsonProperty("execution_succeeded")]
        [STJS.JsonPropertyName("execution_succeeded")]
        public ApprovalRequestStatusDetailsExecutionSucceeded ExecutionSucceeded { get; set; }

        /// <summary>
        /// Deprecated: use expired status instead.
        /// </summary>
        [JsonProperty("expired")]
        [STJS.JsonPropertyName("expired")]
        public ApprovalRequestStatusDetailsExpired Expired { get; set; }

        /// <summary>
        /// Details when the approval request failed.
        /// </summary>
        [JsonProperty("failed")]
        [STJS.JsonPropertyName("failed")]
        public ApprovalRequestStatusDetailsFailed Failed { get; set; }

        /// <summary>
        /// Deprecated: use requires_review status instead.
        /// </summary>
        [JsonProperty("pending")]
        [STJS.JsonPropertyName("pending")]
        public ApprovalRequestStatusDetailsPending Pending { get; set; }

        /// <summary>
        /// Deprecated: use rejected status instead.
        /// </summary>
        [JsonProperty("rejected")]
        [STJS.JsonPropertyName("rejected")]
        public ApprovalRequestStatusDetailsRejected Rejected { get; set; }

        /// <summary>
        /// Details when the approval request succeeded.
        /// </summary>
        [JsonProperty("succeeded")]
        [STJS.JsonPropertyName("succeeded")]
        public ApprovalRequestStatusDetailsSucceeded Succeeded { get; set; }
    }
}
