// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionWechatPayRedirectToAndroidApp : StripeEntity<PaymentIntentNextActionWechatPayRedirectToAndroidApp>
    {
        /// <summary>
        /// app_id is the APP ID registered on WeChat open platform.
        /// </summary>
        [JsonProperty("app_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("app_id")]
#endif

        public string AppId { get; set; }

        /// <summary>
        /// nonce_str is a random string.
        /// </summary>
        [JsonProperty("nonce_str")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nonce_str")]
#endif

        public string NonceStr { get; set; }

        /// <summary>
        /// package is static value.
        /// </summary>
        [JsonProperty("package")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("package")]
#endif

        public string Package { get; set; }

        /// <summary>
        /// an unique merchant ID assigned by WeChat Pay.
        /// </summary>
        [JsonProperty("partner_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("partner_id")]
#endif

        public string PartnerId { get; set; }

        /// <summary>
        /// an unique trading ID assigned by WeChat Pay.
        /// </summary>
        [JsonProperty("prepay_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prepay_id")]
#endif

        public string PrepayId { get; set; }

        /// <summary>
        /// A signature.
        /// </summary>
        [JsonProperty("sign")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sign")]
#endif

        public string Sign { get; set; }

        /// <summary>
        /// Specifies the current time in epoch format.
        /// </summary>
        [JsonProperty("timestamp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
#endif

        public string Timestamp { get; set; }
    }
}
