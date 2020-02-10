namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ShippingOptions : INestedOptions
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public AddressOptions Address { get; set; }
    }
}
