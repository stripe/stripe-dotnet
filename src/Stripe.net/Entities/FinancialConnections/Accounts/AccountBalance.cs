// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountBalance : StripeEntity<AccountBalance>
    {
        /// <summary>
        /// The time that the external institution calculated this balance. Measured in seconds
        /// since the Unix epoch.
        /// </summary>
        [JsonProperty("as_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("as_of")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime AsOf { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("cash")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cash")]
#endif

        public AccountBalanceCash Cash { get; set; }

        [JsonProperty("credit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit")]
#endif

        public AccountBalanceCredit Credit { get; set; }

        /// <summary>
        /// The balances owed to (or by) the account holder, before subtracting any outbound pending
        /// transactions or adding any inbound pending transactions.
        ///
        /// Each key is a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase.
        ///
        /// Each value is a integer amount. A positive amount indicates money owed to the account
        /// holder. A negative amount indicates money owed by the account holder.
        /// </summary>
        [JsonProperty("current")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current")]
#endif

        public Dictionary<string, long> Current { get; set; }

        /// <summary>
        /// The <c>type</c> of the balance. An additional hash is included on the balance with a
        /// name matching this value.
        /// One of: <c>cash</c>, or <c>credit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
