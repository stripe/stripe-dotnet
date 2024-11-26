// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceAlipay : StripeEntity<SourceAlipay>
    {
        [JsonProperty("data_string")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data_string")]
#endif
        public string DataString { get; set; }

        [JsonProperty("native_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("native_url")]
#endif
        public string NativeUrl { get; set; }

        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }
    }
}
