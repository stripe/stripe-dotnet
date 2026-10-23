// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountCreateStorageOptions : INestedOptions
    {
        /// <summary>
        /// Crypto-specific storage configuration. Fiat currencies remain configured only through
        /// <c>holds_currencies</c>.
        /// </summary>
        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public FinancialAccountCreateStorageCryptoOptions Crypto { get; set; }

        /// <summary>
        /// The usage type for funds in this FinancialAccount. Defaults to BUSINESS if not
        /// specified.
        /// One of: <c>business</c>, or <c>consumer</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("funds_usage_type")]
        [STJS.JsonPropertyName("funds_usage_type")]
        public string FundsUsageType { get; set; }

        /// <summary>
        /// The currencies that the storage FinancialAccount can hold a balance in. Three-letter ISO
        /// currency code, in lowercase. Must be a subset of the currencies requested in
        /// <c>configuration.storer.features.holds_currencies</c> of the v2/accounts API.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public List<string> HoldsCurrencies { get; set; }
    }
}
