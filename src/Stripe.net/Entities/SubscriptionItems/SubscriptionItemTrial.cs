// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemTrial : StripeEntity<SubscriptionItemTrial>
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
