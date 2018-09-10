namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripePlanProductCreateOptions : INestedOptions, ISupportMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
