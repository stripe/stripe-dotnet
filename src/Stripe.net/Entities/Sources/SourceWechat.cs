// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceWechat : StripeEntity<SourceWechat>
    {
        [JsonProperty("prepay_id")]
        public string PrepayId { get; set; }

        [JsonProperty("qr_code_url")]
        public string QrCodeUrl { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
