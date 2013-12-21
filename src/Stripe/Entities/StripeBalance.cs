using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe
{
    public class StripeBalance :StripeBase
    {
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }
        [JsonProperty("pending")]
        public StripeAmount[] Pending { get; set; }
        [JsonProperty("available")]
        public StripeAmount[] Available { get; set; }
    }
}
