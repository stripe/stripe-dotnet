// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QueryRunQuery : StripeEntity<QueryRunQuery>
    {
        /// <summary>
        /// Ad-hoc SQL to execute. The maximum length is 100,000 characters.
        /// </summary>
        [JsonProperty("sql")]
        [STJS.JsonPropertyName("sql")]
        public string Sql { get; set; }
    }
}
