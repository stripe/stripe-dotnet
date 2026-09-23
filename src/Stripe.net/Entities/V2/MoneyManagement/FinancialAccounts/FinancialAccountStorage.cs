// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStorage : StripeEntity<FinancialAccountStorage>
    {
        /// <summary>
        /// Crypto-specific storage configuration. Only populated when <c>storage.crypto</c> is
        /// passed in the <c>include</c> parameter and the FinancialAccount stores crypto assets.
        /// Fiat currencies remain configured only through <c>holds_currencies</c>.
        /// </summary>
        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public FinancialAccountStorageCrypto Crypto { get; set; }

        /// <summary>
        /// The usage type for funds in this FinancialAccount. Can be used to specify that the funds
        /// are for Consumer activity.
        /// One of: <c>business</c>, or <c>consumer</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("funds_usage_type")]
        [STJS.JsonPropertyName("funds_usage_type")]
        public string FundsUsageType { get; set; }

        /// <summary>
        /// The currencies that this FinancialAccount can hold.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public List<string> HoldsCurrencies { get; set; }
    }
}
