// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCode : StripeEntity<PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCode>
    {
        /// <summary>
        /// The URL to the hosted Cash App Pay instructions page, which allows customers to view the
        /// QR code, and supports QR code refreshing on expiration.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_instructions_url")]
#endif
        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// The url for mobile redirect based auth.
        /// </summary>
        [JsonProperty("mobile_auth_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobile_auth_url")]
#endif
        public string MobileAuthUrl { get; set; }

        [JsonProperty("qr_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("qr_code")]
#endif
        public PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCodeQrCode QrCode { get; set; }
    }
}
