namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextAction : StripeEntity<PaymentIntentNextAction>
    {
        [JsonProperty("alipay_handle_redirect")]
        public PaymentIntentNextActionAlipayHandleRedirect AlipayHandleRedirect { get; set; }

        [JsonProperty("redirect_to_url")]
        public PaymentIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
