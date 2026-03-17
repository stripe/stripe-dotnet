// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BatchJobStatusDetailsInProgress : StripeEntity<BatchJobStatusDetailsInProgress>
    {
        /// <summary>
        /// The number of records that failed processing so far.
        /// </summary>
        [JsonProperty("failure_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_count")]
#endif
        public long FailureCount { get; set; }

        /// <summary>
        /// The number of records that were successfully processed so far.
        /// </summary>
        [JsonProperty("success_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("success_count")]
#endif
        public long SuccessCount { get; set; }
    }
}
