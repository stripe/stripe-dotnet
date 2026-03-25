// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BatchJobStatusDetailsInProgress : StripeEntity<BatchJobStatusDetailsInProgress>
    {
        /// <summary>
        /// The number of records that failed processing so far.
        /// </summary>
        [JsonProperty("failure_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("failure_count")]
        public long FailureCount { get; set; }

        /// <summary>
        /// The number of records that were successfully processed so far.
        /// </summary>
        [JsonProperty("success_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
