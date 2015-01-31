using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripePlanUpdateOptions
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("statement_description")]
        public string StatementDescription { get; set; }
    }
}
