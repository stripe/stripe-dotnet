namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeEventRequest : StripeEntityWithId
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }
}
