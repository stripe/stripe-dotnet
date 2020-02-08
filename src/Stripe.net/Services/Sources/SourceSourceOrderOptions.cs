namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceSourceOrderOptions : INestedOptions
    {
        [JsonProperty("items")]
        public List<SourceSourceOrderItemOptions> Items { get; set; }

        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }
    }
}
