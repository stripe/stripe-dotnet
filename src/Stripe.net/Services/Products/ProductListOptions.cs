namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductListOptions : ListOptions
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
