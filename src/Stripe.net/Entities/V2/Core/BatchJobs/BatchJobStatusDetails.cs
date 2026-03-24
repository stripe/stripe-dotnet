// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BatchJobStatusDetails : StripeEntity<BatchJobStatusDetails>
    {
        /// <summary>
        /// Additional details for the <c>BATCH_FAILED</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("batch_failed")]
        [STJS.JsonPropertyName("batch_failed")]
        public BatchJobStatusDetailsBatchFailed BatchFailed { get; set; }

        /// <summary>
        /// Additional details for the <c>CANCELED</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("canceled")]
        [STJS.JsonPropertyName("canceled")]
        public BatchJobStatusDetailsCanceled Canceled { get; set; }

        /// <summary>
        /// Additional details for the <c>COMPLETE</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("complete")]
        [STJS.JsonPropertyName("complete")]
        public BatchJobStatusDetailsComplete Complete { get; set; }

        /// <summary>
        /// Additional details for the <c>IN_PROGRESS</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("in_progress")]
        [STJS.JsonPropertyName("in_progress")]
        public BatchJobStatusDetailsInProgress InProgress { get; set; }

        /// <summary>
        /// Additional details for the <c>READY_FOR_UPLOAD</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("ready_for_upload")]
        [STJS.JsonPropertyName("ready_for_upload")]
        public BatchJobStatusDetailsReadyForUpload ReadyForUpload { get; set; }

        /// <summary>
        /// Additional details for the <c>TIMEOUT</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("timeout")]
        [STJS.JsonPropertyName("timeout")]
        public BatchJobStatusDetailsTimeout Timeout { get; set; }

        /// <summary>
        /// Additional details for the <c>VALIDATING</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("validating")]
        [STJS.JsonPropertyName("validating")]
        public BatchJobStatusDetailsValidating Validating { get; set; }

        /// <summary>
        /// Additional details for the <c>VALIDATION_FAILED</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("validation_failed")]
        [STJS.JsonPropertyName("validation_failed")]
        public BatchJobStatusDetailsValidationFailed ValidationFailed { get; set; }
    }
}
