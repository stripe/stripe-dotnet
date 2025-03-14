// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceWechat : StripeEntity<SourceWechat>
    {
        [JsonProperty("prepay_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prepay_id")]
#endif
        public string PrepayId { get; set; }

        [JsonProperty("qr_code_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("qr_code_url")]
#endif
        public string QrCodeUrl { get; set; }

        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }
    }
}
