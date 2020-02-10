namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardShippingOptions : INestedOptions
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [Obsolete("Use Service instead")]
        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
