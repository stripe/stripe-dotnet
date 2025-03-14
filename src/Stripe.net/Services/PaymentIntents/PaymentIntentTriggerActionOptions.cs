// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentTriggerActionOptions : BaseOptions
    {
        /// <summary>
        /// True to simulate success, false to simulate failure.
        /// </summary>
        [JsonProperty("scan_qr_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scan_qr_code")]
#endif
        public PaymentIntentScanQrCodeOptions ScanQrCode { get; set; }

        /// <summary>
        /// The type of action to be simulated.
        /// One of: <c>expire</c>, or <c>fund</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
