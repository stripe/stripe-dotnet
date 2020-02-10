namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemListOptions : ListOptions
    {
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
