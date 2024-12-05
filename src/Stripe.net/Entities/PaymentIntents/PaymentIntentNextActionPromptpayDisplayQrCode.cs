// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionPromptpayDisplayQrCode : StripeEntity<PaymentIntentNextActionPromptpayDisplayQrCode>
    {
        /// <summary>
        /// The raw data string used to generate QR code, it should be used together with QR code
        /// library.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// The URL to the hosted PromptPay instructions page, which allows customers to view the
        /// PromptPay QR code.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// The PNG path used to render the QR code, can be used as the source in an HTML img tag.
        /// </summary>
        [JsonProperty("image_url_png")]
        public string ImageUrlPng { get; set; }

        /// <summary>
        /// The SVG path used to render the QR code, can be used as the source in an HTML img tag.
        /// </summary>
        [JsonProperty("image_url_svg")]
        public string ImageUrlSvg { get; set; }
    }
}
