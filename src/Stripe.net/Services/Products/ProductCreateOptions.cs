namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ProductCreateOptions : BaseOptions, IHasId, IHasMetadata
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("attributes")]
        public List<string> Attributes { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("deactivate_on")]
        public List<string> DeactivateOn { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public List<string> Images { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("package_dimensions")]
        public PackageDimensionOptions PackageDimensions { get; set; }

        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unit_label")]
        public string UnitLabel { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
