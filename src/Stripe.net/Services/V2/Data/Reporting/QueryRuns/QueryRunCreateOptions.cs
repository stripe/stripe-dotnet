// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Reporting
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QueryRunCreateOptions : BaseOptions
    {
        /// <summary>
        /// Optional settings to customize the results of the <c>QueryRun</c>.
        /// </summary>
        [JsonProperty("result_options")]
        [STJS.JsonPropertyName("result_options")]
        public QueryRunCreateResultOptionsOptions ResultOptions { get; set; }

        /// <summary>
        /// The SQL to execute.
        /// </summary>
        [JsonProperty("sql")]
        [STJS.JsonPropertyName("sql")]
        public string Sql { get; set; }
    }
}
