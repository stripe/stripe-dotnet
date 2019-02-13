namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionTransferDataOptions : INestedOptions
    {
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
