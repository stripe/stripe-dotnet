using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBalance : StripeEntity
    {
        [JsonProperty("available")]
        public List<StripeBalanceAmount> Available { get; set; }

        [JsonProperty("connect_reserved")]
        public List<StripeBalanceAmount> ConnectReserved { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("pending")]
        public List<StripeBalanceAmount> Pending { get; set; }
    }
}
