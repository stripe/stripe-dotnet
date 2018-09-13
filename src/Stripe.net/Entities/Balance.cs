namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Balance : StripeEntity
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("available")]
        public List<BalanceAmount> Available { get; set; }

        [JsonProperty("connect_reserved")]
        public List<BalanceAmount> ConnectReserved { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("pending")]
        public List<BalanceAmount> Pending { get; set; }
    }
}
