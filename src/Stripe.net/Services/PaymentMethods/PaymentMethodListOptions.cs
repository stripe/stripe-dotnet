namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodListOptions : ListOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
