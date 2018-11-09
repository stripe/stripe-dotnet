namespace Stripe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;

    public class PaymentIntentSourceAction : StripeEntity
    {
        [JsonProperty("authorize_with_url")]
        public PaymentIntentSourceActionAuthorizeWithUrl AuthorizeWithUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
