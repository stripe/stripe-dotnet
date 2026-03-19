// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A customer's <c>Cash balance</c> represents real funds. Customers can add funds to their
    /// cash balance by sending a bank transfer. These funds can be used for payment and can
    /// eventually be paid out to your bank account.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CashBalance : StripeEntity<CashBalance>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// A hash of all cash balances available to this customer. You cannot delete a customer
        /// with any cash balances, even if the balance is 0. Amounts are represented in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public Dictionary<string, long> Available { get; set; }

        /// <summary>
        /// The ID of the customer whose cash balance this object represents.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The ID of an Account representing a customer whose cash balance this object represents.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public CashBalanceSettings Settings { get; set; }
    }
}
