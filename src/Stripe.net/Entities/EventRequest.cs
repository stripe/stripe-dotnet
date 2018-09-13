namespace Stripe
{
    using Newtonsoft.Json;

    public class EventRequest : StripeEntityWithId
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }
}
