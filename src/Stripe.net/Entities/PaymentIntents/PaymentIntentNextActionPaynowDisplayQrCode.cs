// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionPaynowDisplayQrCode : StripeEntity<PaymentIntentNextActionPaynowDisplayQrCode>
    {
        /// <summary>
        /// The raw data string used to generate QR code, it should be used together with QR code
        /// library.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif
        public string Data { get; set; }

        /// <summary>
        /// The URL to the hosted PayNow instructions page, which allows customers to view the
        /// PayNow QR code.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_instructions_url")]
#endif
        public string HostedInstructionsUrl { get; set; }

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
