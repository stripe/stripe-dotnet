using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCouponUpdateOptions
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
