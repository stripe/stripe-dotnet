// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsWechatPay : StripeEntity<PaymentIntentPaymentMethodOptionsWechatPay>
    {
        /// <summary>
        /// The app ID registered with WeChat Pay. Only required when client is ios or android.
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// The client type that the end customer will pay from.
        /// One of: <c>android</c>, <c>ios</c>, or <c>web</c>.
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }
    }
}
