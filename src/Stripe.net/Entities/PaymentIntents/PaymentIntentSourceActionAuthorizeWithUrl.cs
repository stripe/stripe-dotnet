namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentSourceActionAuthorizeWithUrl : StripeEntity, IPaymentIntentSourceActionValue
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
