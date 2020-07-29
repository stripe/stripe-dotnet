namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Balance : StripeEntity<Balance>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Funds that are available to be transferred or paid out, whether automatically by Stripe
        /// or explicitly via the Transfers API or Payouts API.
        /// </summary>
        [JsonProperty("available")]
        public List<BalanceAmount> Available { get; set; }

        /// <summary>
        /// Funds held due to negative balances on connected Custom accounts.
        /// </summary>
        [JsonProperty("connect_reserved")]
        public List<BalanceAmount> ConnectReserved { get; set; }

        /// <summary>
        /// Funds that can be spent on your cards issued via Issuing.
        /// </summary>
        [JsonProperty("issuing")]
        public BalanceDetails Issuing { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Funds that are not yet available in the balance, due to the 7-day rolling pay cycle.
        /// </summary>
        [JsonProperty("pending")]
        public List<BalanceAmount> Pending { get; set; }
    }
}
