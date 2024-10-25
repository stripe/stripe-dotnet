// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentTriggerActionOptions : BaseOptions
    {
        /// <summary>
        /// True to simulate success, false to simulate failure.
        /// </summary>
        [JsonProperty("scan_qr_code")]
        public PaymentIntentScanQrCodeOptions ScanQrCode { get; set; }

        /// <summary>
        /// The type of action to be simulated.
        /// One of: <c>expire</c>, or <c>fund</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
