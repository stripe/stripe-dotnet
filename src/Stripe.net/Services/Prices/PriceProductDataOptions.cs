namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PriceProductDataOptions : INestedOptions, IHasId, IHasMetadata
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("unit_label")]
        public string UnitLabel { get; set; }
    }
}
