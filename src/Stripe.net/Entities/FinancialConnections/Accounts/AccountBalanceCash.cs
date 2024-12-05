// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccountBalanceCash : StripeEntity<AccountBalanceCash>
    {
        /// <summary>
        /// The funds available to the account holder. Typically this is the current balance after
        /// subtracting any outbound pending transactions and adding any inbound pending
        /// transactions.
        ///
        /// Each key is a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase.
        ///
        /// Each value is a integer amount. A positive amount indicates money owed to the account
        /// holder. A negative amount indicates money owed by the account holder.
        /// </summary>
        [JsonProperty("available")]
        public Dictionary<string, long> Available { get; set; }
    }
}
