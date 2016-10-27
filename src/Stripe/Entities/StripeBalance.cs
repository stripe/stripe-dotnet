using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBalance : StripeEntity
    {
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("available")]
        public List<StripeBalanceAmount> Available { get; set; }

        [JsonProperty("pending")]
        public List<StripeBalanceAmount> Pending { get; set; }
    }
}
