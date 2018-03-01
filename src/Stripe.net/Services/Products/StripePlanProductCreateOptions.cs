using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripePlanProductCreateOptions : INestedOptions, ISupportMetadata
    {
        [JsonProperty("product[id]")]
        public string Id { get; set; }
        
        [JsonProperty("product[name]")]
        public string Name { get; set; }

        [JsonProperty("product[statement_descriptor]")]
        public string StatementDescriptor { get; set; }
        
        [JsonProperty("product[metadata]")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
