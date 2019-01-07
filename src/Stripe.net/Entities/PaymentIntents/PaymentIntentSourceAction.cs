namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentSourceAction : StripeEntity
    {
        [JsonProperty("authorize_with_url")]
        public PaymentIntentSourceActionAuthorizeWithUrl AuthorizeWithUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
