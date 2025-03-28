// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// A hash of all cash balances available to this customer. You cannot delete a customer
        /// with any cash balances, even if the balance is 0. Amounts are represented in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public Dictionary<string, long> Available { get; set; }

        /// <summary>
        /// The ID of the customer whose cash balance this object represents.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The ID of the account whose cash balance this object represents.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        [JsonProperty("settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settings")]
#endif
        public CashBalanceSettings Settings { get; set; }
    }
}
