// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCodeQrCode : StripeEntity<PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCodeQrCode>
    {
        /// <summary>
        /// The date (unix timestamp) when the QR code expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
