namespace Stripe
{
    using Newtonsoft.Json;

    public class EphemeralKeyAssociatedObject : StripeEntity<EphemeralKeyAssociatedObject>
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
