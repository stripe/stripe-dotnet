// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionWechatPayRedirectToIosApp : StripeEntity<PaymentIntentNextActionWechatPayRedirectToIosApp>
    {
        /// <summary>
        /// An universal link that redirect to WeChat Pay app.
        /// </summary>
        [JsonProperty("native_url")]
        [STJS.JsonPropertyName("native_url")]
        public string NativeUrl { get; set; }
    }
}
