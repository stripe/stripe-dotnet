namespace Stripe
{
    using Newtonsoft.Json;

    public class EphemeralKeyAssociatedObject : StripeEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
