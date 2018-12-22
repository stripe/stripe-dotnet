namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SkuListOptions : ListOptions
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        [JsonProperty("ids")]
        public List<string> Ids { get; set; }

        [JsonProperty("in_stock")]
        public bool? InStock { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
