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
        /// Details about the <c>BatchJob</c> failure.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public string Error { get; set; }
    }
}
