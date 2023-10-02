// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A historical balance for the account on a particular day. It may be sourced from a
    /// balance snapshot provided by a financial institution, or inferred using transactions
    /// data.
    /// </summary>
    public class AccountInferredBalance : StripeEntity<AccountInferredBalance>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The time for which this balance was calculated, measured in seconds since the Unix
        /// epoch. If the balance was computed by Stripe and not provided directly by a financial
        /// institution, it will always be 23:59:59 UTC.
        /// </summary>
        [JsonProperty("as_of")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime AsOf { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The balances owed to (or by) the account holder.
        ///
        /// Each key is a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase.
        ///
        /// Each value is a integer amount. A positive amount indicates money owed to the account
        /// holder. A negative amount indicates money owed by the account holder.
        /// </summary>
        [JsonProperty("current")]
        public Dictionary<string, long> Current { get; set; }
    }
}
