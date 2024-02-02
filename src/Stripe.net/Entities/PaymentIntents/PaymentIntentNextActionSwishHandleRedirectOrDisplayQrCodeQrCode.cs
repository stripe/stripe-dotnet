// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCodeQrCode : StripeEntity<PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCodeQrCode>
    {
        /// <summary>
        /// The raw data string used to generate QR code, it should be used together with QR code
        /// library.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// The image_url_png string used to render QR code.
        /// </summary>
        [JsonProperty("image_url_png")]
        public string ImageUrlPng { get; set; }

        /// <summary>
        /// The image_url_svg string used to render QR code.
        /// </summary>
        [JsonProperty("image_url_svg")]
        public string ImageUrlSvg { get; set; }
    }
}
