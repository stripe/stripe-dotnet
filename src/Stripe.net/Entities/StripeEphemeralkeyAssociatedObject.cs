namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeEphemeralKeyAssociatedObject : StripeEntityWithId
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}