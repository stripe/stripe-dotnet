namespace Stripe
{
    using Newtonsoft.Json;

    public class EphemeralKeyAssociatedObject : StripeEntityWithId
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}