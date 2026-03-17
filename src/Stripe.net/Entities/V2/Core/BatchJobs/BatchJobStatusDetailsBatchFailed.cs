// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BatchJobStatusDetailsBatchFailed : StripeEntity<BatchJobStatusDetailsBatchFailed>
    {
        /// <summary>
        /// Details about the <c>BatchJob</c> failure.
        /// </summary>
        [JsonProperty("error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error")]
#endif
        public string Error { get; set; }
    }
}
