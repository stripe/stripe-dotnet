// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceAlipay : StripeEntity<SourceAlipay>
    {
        [JsonProperty("data_string")]
        [STJS.JsonPropertyName("data_string")]
        public string DataString { get; set; }

        [JsonProperty("native_url")]
        [STJS.JsonPropertyName("native_url")]
        public string NativeUrl { get; set; }

        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
