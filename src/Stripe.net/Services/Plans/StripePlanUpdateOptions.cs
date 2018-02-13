using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripePlanUpdateOptions : StripeBaseOptions
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }
    }
}
