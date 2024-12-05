// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionWechatPayRedirectToIosApp : StripeEntity<PaymentIntentNextActionWechatPayRedirectToIosApp>
    {
        /// <summary>
        /// An universal link that redirect to WeChat Pay app.
        /// </summary>
        [JsonProperty("native_url")]
        public string NativeUrl { get; set; }
    }
}
