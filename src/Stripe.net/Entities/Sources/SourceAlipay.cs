// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceAlipay : StripeEntity<SourceAlipay>
    {
        [JsonProperty("data_string")]
        public string DataString { get; set; }

        [JsonProperty("native_url")]
        public string NativeUrl { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
