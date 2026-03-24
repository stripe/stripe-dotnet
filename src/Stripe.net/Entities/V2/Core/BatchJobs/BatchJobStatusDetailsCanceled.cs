// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BatchJobStatusDetailsCanceled : StripeEntity<BatchJobStatusDetailsCanceled>
    {
        /// <summary>
        /// The total number of records that failed processing.
        /// </summary>
        [JsonProperty("failure_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("failure_count")]
        public long FailureCount { get; set; }

        /// <summary>
        /// The output file details. If BatchJob is cancelled it's provided only if there is already
        /// output at this point.
        /// </summary>
        [JsonProperty("output_file")]
        [STJS.JsonPropertyName("output_file")]
        public BatchJobStatusDetailsCanceledOutputFile OutputFile { get; set; }

        /// <summary>
        /// The total number of records that were successfully processed.
        /// </summary>
        [JsonProperty("success_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
