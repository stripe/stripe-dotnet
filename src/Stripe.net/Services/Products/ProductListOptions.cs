namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ProductListOptions : ListOptionsWithCreated
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("ids")]
        public List<string> Ids { get; set; }

        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
