// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionWechatPayRedirectToMiniProgram : StripeEntity<PaymentIntentNextActionWechatPayRedirectToMiniProgram>
    {
        /// <summary>
        /// Mini Program ID registered on WeChat Open Platform.
        /// </summary>
        [JsonProperty("app_id")]
        [STJS.JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// Random string.
        /// </summary>
        [JsonProperty("nonce_str")]
        [STJS.JsonPropertyName("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// Unique trading ID assigned by WeChat Pay.
        /// </summary>
        [JsonProperty("prepay_id")]
        [STJS.JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; }

        /// <summary>
        /// Signature.
        /// </summary>
        [JsonProperty("sign")]
        [STJS.JsonPropertyName("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// Signature type.
        /// </summary>
        [JsonProperty("sign_type")]
        [STJS.JsonPropertyName("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// Current time in epoch format.
        /// </summary>
        [JsonProperty("timestamp")]
        [STJS.JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }
}
