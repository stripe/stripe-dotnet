namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EphemeralKeyCreateOptions : BaseOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("issuing_card")]
        public string IssuingCard { get; set; }
    }
}
