// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BatchJobStatusDetailsValidating : StripeEntity<BatchJobStatusDetailsValidating>
    {
        /// <summary>
        /// The number of records that were validated. Note that there is no failure counter here;
        /// once we have any validation failures we give up.
        /// </summary>
        [JsonProperty("validated_count")]
        [STJS.JsonPropertyName("validated_count")]
        public long ValidatedCount { get; set; }
    }
}
