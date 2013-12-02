using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBalance
    {
        [JsonProperty("livemode")]
        public bool? LiveMode { get; set; }

        [JsonProperty("pending")]
        public StripeAmount[] Pending { get; set; }

        [JsonProperty("available")]
        public StripeAmount[] Available { get; set; }
    }
}
