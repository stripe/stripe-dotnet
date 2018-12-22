namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

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
