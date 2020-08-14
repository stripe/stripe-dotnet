namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextAction : StripeEntity<PaymentIntentNextAction>
    {
        [JsonProperty("alipay_handle_redirect")]
        public PaymentIntentNextActionAlipayHandleRedirect AlipayHandleRedirect { get; set; }

        [JsonProperty("redirect_to_url")]
        public PaymentIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        /// <summary>
        /// Type of the next action to perform, one of <c>redirect_to_url</c> or
        /// <c>use_stripe_sdk</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
