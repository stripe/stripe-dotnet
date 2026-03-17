// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentNextActionUpiHandleRedirectOrDisplayQrCode : StripeEntity<SetupIntentNextActionUpiHandleRedirectOrDisplayQrCode>
    {
        /// <summary>
        /// The URL to the hosted UPI instructions page, which allows customers to view the QR code.
        /// </summary>
        [JsonProperty("hosted_instructions_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_instructions_url")]
#endif
        public string HostedInstructionsUrl { get; set; }

        [JsonProperty("qr_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("qr_code")]
#endif
        public SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeQrCode QrCode { get; set; }
    }
}
