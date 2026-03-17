// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BatchJobStatusDetails : StripeEntity<BatchJobStatusDetails>
    {
        /// <summary>
        /// Additional details for the <c>BATCH_FAILED</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("batch_failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("batch_failed")]
#endif
        public BatchJobStatusDetailsBatchFailed BatchFailed { get; set; }

        /// <summary>
        /// Additional details for the <c>CANCELED</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("canceled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled")]
#endif
        public BatchJobStatusDetailsCanceled Canceled { get; set; }

        /// <summary>
        /// Additional details for the <c>COMPLETE</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("complete")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("complete")]
#endif
        public BatchJobStatusDetailsComplete Complete { get; set; }

        /// <summary>
        /// Additional details for the <c>IN_PROGRESS</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("in_progress")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("in_progress")]
#endif
        public BatchJobStatusDetailsInProgress InProgress { get; set; }

        /// <summary>
        /// Additional details for the <c>READY_FOR_UPLOAD</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("ready_for_upload")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ready_for_upload")]
#endif
        public BatchJobStatusDetailsReadyForUpload ReadyForUpload { get; set; }

        /// <summary>
        /// Additional details for the <c>TIMEOUT</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("timeout")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timeout")]
#endif
        public BatchJobStatusDetailsTimeout Timeout { get; set; }

        /// <summary>
        /// Additional details for the <c>VALIDATING</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("validating")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validating")]
#endif
        public BatchJobStatusDetailsValidating Validating { get; set; }

        /// <summary>
        /// Additional details for the <c>VALIDATION_FAILED</c> status of the <c>BatchJob</c>.
        /// </summary>
        [JsonProperty("validation_failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validation_failed")]
#endif
        public BatchJobStatusDetailsValidationFailed ValidationFailed { get; set; }
    }
}
