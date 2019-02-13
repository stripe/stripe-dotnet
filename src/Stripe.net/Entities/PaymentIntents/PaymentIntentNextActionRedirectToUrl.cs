namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionRedirectToUrl : StripeEntity
    {
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
