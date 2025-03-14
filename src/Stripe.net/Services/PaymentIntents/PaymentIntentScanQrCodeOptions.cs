// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentScanQrCodeOptions : INestedOptions
    {
        /// <summary>
        /// Whether the QR Code scan's payment should succeed or fail.
        /// One of: <c>failure</c>, or <c>success</c>.
        /// </summary>
        [JsonProperty("result")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("result")]
#endif
        public string Result { get; set; }
    }
}
