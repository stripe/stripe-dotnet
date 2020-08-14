namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Balance : StripeEntity<Balance>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("available")]
        public List<BalanceAmount> Available { get; set; }

        [JsonProperty("connect_reserved")]
        public List<BalanceAmount> ConnectReserved { get; set; }

        [JsonProperty("issuing")]
        public BalanceDetails Issuing { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("pending")]
        public List<BalanceAmount> Pending { get; set; }
    }
}
