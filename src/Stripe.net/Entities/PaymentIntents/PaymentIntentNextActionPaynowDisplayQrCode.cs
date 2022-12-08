// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionPaynowDisplayQrCode : StripeEntity<PaymentIntentNextActionPaynowDisplayQrCode>
    {
        /// <summary>
        /// The raw data string used to generate QR code, it should be used together with QR code
        /// library.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// The URL to the hosted PayNow instructions page, which allows customers to view the
        /// PayNow QR code.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
        public string HostedInstructionsUrl { get; set; }

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
