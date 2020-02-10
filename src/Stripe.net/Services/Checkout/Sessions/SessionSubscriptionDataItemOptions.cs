namespace Stripe
{
    using Newtonsoft.Json;

    public class SessionSubscriptionDataItemOptions : INestedOptions
    {
        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
