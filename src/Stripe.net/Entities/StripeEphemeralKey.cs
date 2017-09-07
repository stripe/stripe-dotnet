using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeEphemeralKey : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("expires")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Expires { get; set; }

        [JsonProperty("associated_objects")]
        public List<StripeEphemeralKeyAssociatedObject> AssociatedObjects { get; set; }

        // figure out how to get the raw JSON.
    }
}
