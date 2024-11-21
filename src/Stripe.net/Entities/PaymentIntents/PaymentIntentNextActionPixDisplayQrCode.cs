// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionPixDisplayQrCode : StripeEntity<PaymentIntentNextActionPixDisplayQrCode>
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
        /// The date (unix timestamp) when the PIX expires.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL to the hosted pix instructions page, which allows customers to view the pix QR
        /// code.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_instructions_url")]
#endif

        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// The image_url_png string used to render png QR code.
        /// </summary>
        [JsonProperty("image_url_png")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("image_url_png")]
#endif

        public string ImageUrlPng { get; set; }

        /// <summary>
        /// The image_url_svg string used to render svg QR code.
        /// </summary>
        [JsonProperty("image_url_svg")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("image_url_svg")]
#endif

        public string ImageUrlSvg { get; set; }
    }
}
