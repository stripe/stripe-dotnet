using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeSkuListOptions : StripeListOptions
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("in_stock")]
        public bool? InStock { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
