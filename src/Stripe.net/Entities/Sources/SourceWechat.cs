// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceWechat : StripeEntity<SourceWechat>
    {
        [JsonProperty("prepay_id")]
        [STJS.JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; }

        [JsonProperty("qr_code_url")]
        [STJS.JsonPropertyName("qr_code_url")]
        public string QrCodeUrl { get; set; }

        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
