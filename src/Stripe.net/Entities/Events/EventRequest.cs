namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EventRequest : StripeEntity<EventRequest>, IHasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }
}
