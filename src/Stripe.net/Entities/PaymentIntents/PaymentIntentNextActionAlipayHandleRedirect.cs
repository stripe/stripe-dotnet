namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionAlipayHandleRedirect : StripeEntity<PaymentIntentNextActionAlipayHandleRedirect>
    {
        [JsonProperty("native_data")]
        public string NativeData { get; set; }

        [JsonProperty("native_url")]
        public string NativeUrl { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
