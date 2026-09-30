// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QueryRunResultFileColumn : StripeEntity<QueryRunResultFileColumn>
    {
        /// <summary>
        /// The name of the column.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The data type of the column.
        /// One of: <c>bigint</c>, <c>boolean</c>, <c>date</c>, <c>datetime</c>, <c>decimal</c>,
        /// <c>double</c>, <c>integer</c>, <c>timestamp</c>, or <c>varchar</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
