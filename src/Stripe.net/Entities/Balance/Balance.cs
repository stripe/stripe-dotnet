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
        /// or explicitly via the <a href="https://stripe.com/docs/api#transfers">Transfers API</a>
        /// or <a href="https://stripe.com/docs/api#payouts">Payouts API</a>. The available balance
        /// for each currency and payment type can be found in the <c>source_types</c> property.
        /// </summary>
        [JsonProperty("available")]
        public List<BalanceAmount> Available { get; set; }

        /// <summary>
        /// Funds held due to negative balances on connected Custom accounts. The connect reserve
        /// balance for each currency and payment type can be found in the <c>source_types</c>
        /// property.
        /// </summary>
        [JsonProperty("connect_reserved")]
        public List<BalanceAmount> ConnectReserved { get; set; }

        [JsonProperty("issuing")]
        public BalanceDetails Issuing { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Funds that are not yet available in the balance, due to the 7-day rolling pay cycle. The
        /// pending balance for each currency, and for each payment type, can be found in the
        /// <c>source_types</c> property.
        /// </summary>
        [JsonProperty("pending")]
        public List<BalanceAmount> Pending { get; set; }
    }
}
