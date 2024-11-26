// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountBalanceCredit : StripeEntity<AccountBalanceCredit>
    {
        /// <summary>
        /// The credit that has been used by the account holder.
        ///
        /// Each key is a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase.
        ///
        /// Each value is a integer amount. A positive amount indicates money owed to the account
        /// holder. A negative amount indicates money owed by the account holder.
        /// </summary>
        [JsonProperty("used")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("used")]
#endif
        public Dictionary<string, long> Used { get; set; }
    }
}
