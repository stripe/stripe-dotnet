namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EphemeralKeyCreateOptions : BaseOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("issuing_card")]
        public string IssuingCardId { get; set; }

        [JsonIgnore]
        public string StripeVersion { get; set; }
    }
}
