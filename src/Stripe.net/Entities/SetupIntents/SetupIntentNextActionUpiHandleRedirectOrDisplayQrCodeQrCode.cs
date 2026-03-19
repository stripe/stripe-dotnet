// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeQrCode : StripeEntity<SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeQrCode>
    {
        /// <summary>
        /// The date (unix timestamp) when the QR code expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
