namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderUpdateShippingOptions : INestedOptions
    {
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
