// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionWechatPayRedirectToAndroidApp : StripeEntity<PaymentIntentNextActionWechatPayRedirectToAndroidApp>
    {
        /// <summary>
        /// app_id is the APP ID registered on WeChat open platform.
        /// </summary>
        [JsonProperty("app_id")]
        [STJS.JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// nonce_str is a random string.
        /// </summary>
        [JsonProperty("nonce_str")]
        [STJS.JsonPropertyName("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// package is static value.
        /// </summary>
        [JsonProperty("package")]
        [STJS.JsonPropertyName("package")]
        public string Package { get; set; }

        /// <summary>
        /// an unique merchant ID assigned by WeChat Pay.
        /// </summary>
        [JsonProperty("partner_id")]
        [STJS.JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// an unique trading ID assigned by WeChat Pay.
        /// </summary>
        [JsonProperty("prepay_id")]
        [STJS.JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; }

        /// <summary>
        /// A signature.
        /// </summary>
        [JsonProperty("sign")]
        [STJS.JsonPropertyName("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// Specifies the current time in epoch format.
        /// </summary>
        [JsonProperty("timestamp")]
        [STJS.JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }
}
