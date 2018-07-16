namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeEphemeralKeyCreateOptions : StripeBaseOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonIgnore]
        public string StripeVersion { get; set; }
    }
}
