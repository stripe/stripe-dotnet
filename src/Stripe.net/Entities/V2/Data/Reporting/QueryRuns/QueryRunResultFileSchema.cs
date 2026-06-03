// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Reporting
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QueryRunResultFileSchema : StripeEntity<QueryRunResultFileSchema>
    {
        /// <summary>
        /// The name of the column.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of the column.
        /// One of: <c>boolean</c>, <c>double</c>, <c>bigint</c>, <c>varchar</c>, or
        /// <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
