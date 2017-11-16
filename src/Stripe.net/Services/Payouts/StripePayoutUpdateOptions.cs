using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripePayoutUpdateOptions : StripeBaseOptions
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
