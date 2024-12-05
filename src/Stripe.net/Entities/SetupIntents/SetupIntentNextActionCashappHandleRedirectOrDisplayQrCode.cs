// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentNextActionCashappHandleRedirectOrDisplayQrCode : StripeEntity<SetupIntentNextActionCashappHandleRedirectOrDisplayQrCode>
    {
        /// <summary>
        /// The URL to the hosted Cash App Pay instructions page, which allows customers to view the
        /// QR code, and supports QR code refreshing on expiration.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// The url for mobile redirect based auth.
        /// </summary>
        [JsonProperty("mobile_auth_url")]
        public string MobileAuthUrl { get; set; }

        [JsonProperty("qr_code")]
        public SetupIntentNextActionCashappHandleRedirectOrDisplayQrCodeQrCode QrCode { get; set; }
    }
}
