// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionAlipayHandleRedirect : StripeEntity<PaymentIntentNextActionAlipayHandleRedirect>
    {
        /// <summary>
        /// The native data to be used with Alipay SDK you must redirect your customer to in order
        /// to authenticate the payment in an Android App.
        /// </summary>
        [JsonProperty("native_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("native_data")]
#endif
        public string NativeData { get; set; }

        /// <summary>
        /// The native URL you must redirect your customer to in order to authenticate the payment
        /// in an iOS App.
        /// </summary>
        [JsonProperty("native_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("native_url")]
#endif
        public string NativeUrl { get; set; }

        /// <summary>
        /// If the customer does not exit their browser while authenticating, they will be
        /// redirected to this specified URL after completion.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The URL you must redirect your customer to in order to authenticate the payment.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
