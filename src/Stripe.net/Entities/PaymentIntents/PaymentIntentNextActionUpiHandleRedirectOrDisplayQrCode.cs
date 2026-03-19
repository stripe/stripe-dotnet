// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionUpiHandleRedirectOrDisplayQrCode : StripeEntity<PaymentIntentNextActionUpiHandleRedirectOrDisplayQrCode>
    {
        /// <summary>
        /// The URL to the hosted UPI instructions page, which allows customers to view the QR code.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
        [STJS.JsonPropertyName("hosted_instructions_url")]
        public string HostedInstructionsUrl { get; set; }

        [JsonProperty("qr_code")]
        [STJS.JsonPropertyName("qr_code")]
        public PaymentIntentNextActionUpiHandleRedirectOrDisplayQrCodeQrCode QrCode { get; set; }
    }
}
