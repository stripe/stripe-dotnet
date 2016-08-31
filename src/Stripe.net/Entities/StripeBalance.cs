using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeBalance
    {
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("available")]
        public List<StripeBalanceAmount> Available { get; set; }

        [JsonProperty("pending")]
        public List<StripeBalanceAmount> Pending { get; set; }
    }
}
