using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferReversalUpdateOptions : StripeBaseOptions
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
