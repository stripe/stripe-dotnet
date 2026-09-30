// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QueryRunCreateOptions : BaseOptions
    {
        /// <summary>
        /// The dataset to query.
        /// One of: <c>analytical</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("dataset")]
        [STJS.JsonPropertyName("dataset")]
        public string Dataset { get; set; }

        /// <summary>
        /// The file format for the result.
        /// One of: <c>csv</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("format")]
        [STJS.JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// The query to execute.
        /// </summary>
        [JsonProperty("query")]
        [STJS.JsonPropertyName("query")]
        public QueryRunCreateQueryOptions Query { get; set; }

        /// <summary>
        /// Optional settings that customize the generated result file.
        /// </summary>
        [JsonProperty("result_options")]
        [STJS.JsonPropertyName("result_options")]
        public QueryRunCreateResultOptionsOptions ResultOptions { get; set; }
    }
}
