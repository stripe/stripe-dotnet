namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentSourceActionAuthorizeWithUrl : StripeEntity
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
