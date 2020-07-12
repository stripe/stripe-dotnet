namespace Stripe
{
    using Newtonsoft.Json;

    public class InventoryOptions : INestedOptions
    {
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
