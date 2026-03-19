// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCode : StripeEntity<PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCode>
    {
        /// <summary>
        /// The URL to the hosted Swish instructions page, which allows customers to view the QR
        /// code.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
        [STJS.JsonPropertyName("hosted_instructions_url")]
        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// The url for mobile redirect based auth (for internal use only and not typically
        /// available in standard API requests).
        /// </summary>
        [JsonProperty("mobile_auth_url")]
        [STJS.JsonPropertyName("mobile_auth_url")]
        public string MobileAuthUrl { get; set; }

        [JsonProperty("qr_code")]
        [STJS.JsonPropertyName("qr_code")]
        public PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCodeQrCode QrCode { get; set; }
    }
}
