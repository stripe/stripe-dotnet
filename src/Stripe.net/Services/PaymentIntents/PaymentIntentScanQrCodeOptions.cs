// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentScanQrCodeOptions : INestedOptions
    {
        /// <summary>
        /// Whether the QR Code scan's payment should succeed or fail.
        /// One of: <c>failure</c>, or <c>success</c>.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
