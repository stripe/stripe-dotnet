// File generated from our OpenAPI spec
namespace Stripe.Sigma
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SchemaTableColumn : StripeEntity<SchemaTableColumn>
    {
        [JsonProperty("comment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("comment")]
#endif
        public string Comment { get; set; }

        [JsonProperty("foreign_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("foreign_key")]
#endif
        public string ForeignKey { get; set; }

        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        [JsonProperty("primary_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_key")]
#endif
        public bool PrimaryKey { get; set; }

        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
