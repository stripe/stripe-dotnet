namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EphemeralKey : StripeEntity<EphemeralKey>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("expires")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Expires { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
