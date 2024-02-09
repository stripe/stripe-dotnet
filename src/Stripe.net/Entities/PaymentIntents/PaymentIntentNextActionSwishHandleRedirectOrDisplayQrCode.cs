// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCode : StripeEntity<PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCode>
    {
        /// <summary>
        /// The URL to the hosted Swish instructions page, which allows customers to view the QR
        /// code or redirect to the Swish mobile app.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
        public string HostedInstructionsUrl { get; set; }

        [JsonProperty("qr_code")]
        public PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCodeQrCode QrCode { get; set; }
    }
}
