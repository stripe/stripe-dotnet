namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionAlipayHandleRedirect : StripeEntity<PaymentIntentNextActionAlipayHandleRedirect>
    {
        /// <summary>
        /// The native data to be used with Alipay SDK you must redirect your customer to in order
        /// to authenticate the payment in an Android App.
        /// </summary>
        [JsonProperty("native_data")]
        public string NativeData { get; set; }

        /// <summary>
        /// The native URL you must redirect your customer to in order to authenticate the payment
        /// in an iOS App.
        /// </summary>
        [JsonProperty("native_url")]
        public string NativeUrl { get; set; }

        /// <summary>
        /// If the customer does not exit their browser while authenticating, they will be
        /// redirected to this specified URL after completion.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The URL you must redirect your customer to in order to authenticate the payment.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
