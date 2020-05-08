namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SkuCreateOptions : BaseOptions, IHasId, IHasMetadata
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

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
