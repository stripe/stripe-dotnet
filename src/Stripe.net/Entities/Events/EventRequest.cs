namespace Stripe
{
    using Newtonsoft.Json;

    public class EventRequest : StripeEntity<EventRequest>, IHasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }
}
