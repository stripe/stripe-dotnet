namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class Dispute : StripeEntity<Dispute>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }
    }
}
