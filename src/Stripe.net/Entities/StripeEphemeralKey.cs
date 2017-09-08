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

        // RawJson is the raw JSON data of the response that was used to initialize this
        // ephemeral key. When working with mobile clients that might only understand
        // one version of the API you should prefer to send this value back to them so
        // that they'll be able to decode an object that's current according to their version.
        public string RawJson {
            get { return this.StripeResponse?.ResponseJson; }
        }
    }
}
