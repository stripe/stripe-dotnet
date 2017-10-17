using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBalance : StripeEntity
    {
        [JsonProperty("available")]
        public List<StripeBalanceAmount> Available { get; set; }

        // TODO: add connect_reserved

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("pending")]
        public List<StripeBalanceAmount> Pending { get; set; }
    }
}
