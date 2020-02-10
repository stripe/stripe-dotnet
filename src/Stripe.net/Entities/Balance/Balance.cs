namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Balance : StripeEntity<Balance>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("available")]
        public List<BalanceAmount> Available { get; set; }

        [JsonProperty("connect_reserved")]
        public List<BalanceAmount> ConnectReserved { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("pending")]
        public List<BalanceAmount> Pending { get; set; }
    }
}
