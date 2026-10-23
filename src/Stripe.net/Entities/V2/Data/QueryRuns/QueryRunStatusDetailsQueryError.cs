// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QueryRunStatusDetailsQueryError : StripeEntity<QueryRunStatusDetailsQueryError>
    {
        /// <summary>
        /// A human-readable description of the error.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// A short identifier categorizing the type of error.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
