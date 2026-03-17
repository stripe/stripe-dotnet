// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BatchJobStatusDetailsValidating : StripeEntity<BatchJobStatusDetailsValidating>
    {
        /// <summary>
        /// The number of records that were validated. Note that there is no failure counter here;
        /// once we have any validation failures we give up.
        /// </summary>
        [JsonProperty("validated_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validated_count")]
#endif
        public long ValidatedCount { get; set; }
    }
}
