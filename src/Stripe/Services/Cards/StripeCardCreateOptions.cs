using System;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCardCreateOptions
    {
        [JsonProperty("source")]
        public string SourceToken { get; set; }

        [JsonProperty("source")]
        public SourceCard SourceCard { get; set; }
        
        [JsonProperty("source")]
        public StripeSourceOptions Source { get; set; }
    }
}
