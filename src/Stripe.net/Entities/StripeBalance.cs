namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripeBalance : StripeEntity
    {
        [JsonProperty("object")]
        public string Object { get; set; }

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
