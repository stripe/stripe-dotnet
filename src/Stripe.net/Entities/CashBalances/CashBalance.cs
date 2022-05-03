// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// A customer's <c>Cash balance</c> represents real funds. Customers can add funds to their
    /// cash balance by sending a bank transfer. These funds can be used for payment and can
    /// eventually be paid out to your bank account.
    /// </summary>
    public class CashBalance : StripeEntity<CashBalance>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A hash of all cash balances available to this customer. You cannot delete a customer
        /// with any cash balances, even if the balance is 0.
        /// </summary>
        [JsonProperty("available")]
        public Dictionary<string, long> Available { get; set; }

        /// <summary>
        /// The ID of the customer whose cash balance this object represents.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("settings")]
        public CashBalanceSettings Settings { get; set; }
    }
}
