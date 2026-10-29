// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BatchJobStatusDetailsBatchFailed : StripeEntity<BatchJobStatusDetailsBatchFailed>
    {
        /// <summary>
        /// Details about the <c>batch_job</c> failure.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public string Error { get; set; }

        /// <summary>
        /// The partial output file details, containing everything processed before the
        /// <c>batch_job</c> failed. Absent for jobs that failed before producing any output.
        /// </summary>
        [JsonProperty("partial_output_file")]
        [STJS.JsonPropertyName("partial_output_file")]
        public BatchJobStatusDetailsBatchFailedPartialOutputFile PartialOutputFile { get; set; }
    }
}
