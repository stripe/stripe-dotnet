// File generated from our OpenAPI spec
namespace Stripe.Sigma
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SchemaTable : StripeEntity<SchemaTable>
    {
        [JsonProperty("columns")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("columns")]
#endif
        public List<SchemaTableColumn> Columns { get; set; }

        [JsonProperty("comment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("comment")]
#endif
        public string Comment { get; set; }

        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        [JsonProperty("section")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("section")]
#endif
        public string Section { get; set; }
    }
}
