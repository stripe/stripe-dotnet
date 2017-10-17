using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBalanceAmount : StripeEntity
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("source_types")]
        public Dictionary<string, long> SourceTypes { get; set; }
    }
 }