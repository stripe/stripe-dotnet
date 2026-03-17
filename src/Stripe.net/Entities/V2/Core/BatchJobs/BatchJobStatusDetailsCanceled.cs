// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BatchJobStatusDetailsCanceled : StripeEntity<BatchJobStatusDetailsCanceled>
    {
        /// <summary>
        /// The total number of records that failed processing.
        /// </summary>
        [JsonProperty("failure_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_count")]
#endif
        public long FailureCount { get; set; }

        /// <summary>
        /// The output file details. If BatchJob is cancelled it's provided only if there is already
        /// output at this point.
        /// </summary>
        [JsonProperty("output_file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("output_file")]
#endif
        public BatchJobStatusDetailsCanceledOutputFile OutputFile { get; set; }

        /// <summary>
        /// The total number of records that were successfully processed.
        /// </summary>
        [JsonProperty("success_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("success_count")]
#endif
        public long SuccessCount { get; set; }
    }
}
