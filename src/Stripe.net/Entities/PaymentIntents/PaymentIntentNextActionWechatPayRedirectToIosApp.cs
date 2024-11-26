// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionWechatPayRedirectToIosApp : StripeEntity<PaymentIntentNextActionWechatPayRedirectToIosApp>
    {
        /// <summary>
        /// An universal link that redirect to WeChat Pay app.
        /// </summary>
        [JsonProperty("native_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("native_url")]
#endif
        public string NativeUrl { get; set; }
    }
}
