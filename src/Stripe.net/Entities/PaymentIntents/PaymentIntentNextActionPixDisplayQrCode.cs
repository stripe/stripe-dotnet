// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentNextActionPixDisplayQrCode : StripeEntity<PaymentIntentNextActionPixDisplayQrCode>
    {
        /// <summary>
        /// The raw data string used to generate QR code, it should be used together with QR code
        /// library.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// The date (unix timestamp) when the PIX expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL to the hosted pix instructions page, which allows customers to view the pix QR
        /// code.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// The image_url_png string used to render png QR code.
        /// </summary>
        [JsonProperty("image_url_png")]
        public string ImageUrlPng { get; set; }

        /// <summary>
        /// The image_url_svg string used to render svg QR code.
        /// </summary>
        [JsonProperty("image_url_svg")]
        public string ImageUrlSvg { get; set; }
    }
}
