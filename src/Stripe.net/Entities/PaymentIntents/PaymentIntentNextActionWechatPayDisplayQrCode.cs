// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionWechatPayDisplayQrCode : StripeEntity<PaymentIntentNextActionWechatPayDisplayQrCode>
    {
        /// <summary>
        /// The data being used to generate QR code.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public string Data { get; set; }

        /// <summary>
        /// The URL to the hosted WeChat Pay instructions page, which allows customers to view the
        /// WeChat Pay QR code.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_instructions_url")]
#endif

        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// The base64 image data for a pre-generated QR code.
        /// </summary>
        [JsonProperty("image_data_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("image_data_url")]
#endif

        public string ImageDataUrl { get; set; }

        /// <summary>
        /// The image_url_png string used to render QR code.
        /// </summary>
        [JsonProperty("image_url_png")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("image_url_png")]
#endif

        public string ImageUrlPng { get; set; }

        /// <summary>
        /// The image_url_svg string used to render QR code.
        /// </summary>
        [JsonProperty("image_url_svg")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("image_url_svg")]
#endif

        public string ImageUrlSvg { get; set; }
    }
}
