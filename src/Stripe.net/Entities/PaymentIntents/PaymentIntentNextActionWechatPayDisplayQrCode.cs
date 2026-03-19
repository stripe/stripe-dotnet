// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionWechatPayDisplayQrCode : StripeEntity<PaymentIntentNextActionWechatPayDisplayQrCode>
    {
        /// <summary>
        /// The data being used to generate QR code.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// The URL to the hosted WeChat Pay instructions page, which allows customers to view the
        /// WeChat Pay QR code.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
        [STJS.JsonPropertyName("hosted_instructions_url")]
        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// The base64 image data for a pre-generated QR code.
        /// </summary>
        [JsonProperty("image_data_url")]
        [STJS.JsonPropertyName("image_data_url")]
        public string ImageDataUrl { get; set; }

        /// <summary>
        /// The image_url_png string used to render QR code.
        /// </summary>
        [JsonProperty("image_url_png")]
        [STJS.JsonPropertyName("image_url_png")]
        public string ImageUrlPng { get; set; }

        /// <summary>
        /// The image_url_svg string used to render QR code.
        /// </summary>
        [JsonProperty("image_url_svg")]
        [STJS.JsonPropertyName("image_url_svg")]
        public string ImageUrlSvg { get; set; }
    }
}
