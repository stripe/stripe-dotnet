namespace Stripe
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class SkuUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("inventory")]
        public InventoryOptions Inventory { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("package_dimensions")]
        public PackageDimensionsOptions PackageDimensions { get; set; }

        [JsonProperty("price")]
        public long? Price { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
