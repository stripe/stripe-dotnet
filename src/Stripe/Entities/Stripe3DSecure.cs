using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class Stripe3DSecure : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }
        
        [JsonProperty("card")]
        public StripeCard Card { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
