using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRefundList
    {
        [JsonProperty("data")]
        public List<StripeRefund> StripeRefunds { get; set; }
    }
}
