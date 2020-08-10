namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TaxRateCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("inclusive")]
        public bool? Inclusive { get; set; }

        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }
    }
}
