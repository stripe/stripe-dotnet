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

        [Obsolete("This is going away in Stripe.net 7.0")]
        [JsonProperty("source")]
        public StripeSourceOptions Source { get; set; }
    }
}
