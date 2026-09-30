// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SchemaColumnForeignKeysTo : StripeEntity<SchemaColumnForeignKeysTo>
    {
        /// <summary>
        /// The name of the referenced column.
        /// </summary>
        [JsonProperty("column")]
        [STJS.JsonPropertyName("column")]
        public string Column { get; set; }

        /// <summary>
        /// The identifier of the referenced schema.
        /// </summary>
        [JsonProperty("schema")]
        [STJS.JsonPropertyName("schema")]
        public string Schema { get; set; }
    }
}
