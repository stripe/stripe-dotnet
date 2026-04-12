// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BalanceSettingsPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// A Boolean indicating whether Stripe should try to reclaim negative balances from an
        /// attached bank account. For details, see <a
        /// href="https://stripe.com/connect/account-balances">Understanding Connect Account
        /// Balances</a>.
        /// </summary>
        [JsonProperty("debit_negative_balances")]
        [STJS.JsonPropertyName("debit_negative_balances")]
        public bool? DebitNegativeBalances { get; set; }

        /// <summary>
        /// Settings specific to the account's payouts.
        /// </summary>
        [JsonProperty("payouts")]
        [STJS.JsonPropertyName("payouts")]
        public BalanceSettingsPaymentsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Settings related to the account's balance settlement timing.
        /// </summary>
        [JsonProperty("settlement_timing")]
        [STJS.JsonPropertyName("settlement_timing")]
        public BalanceSettingsPaymentsSettlementTimingOptions SettlementTiming { get; set; }

        /// <summary>
        /// A hash of settlement currencies to update. Each key is an ISO 4217 currency code, and
        /// the value is either <c>enabled</c> or <c>disabled</c>.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("settlement_currencies")]
        [STJS.JsonPropertyName("settlement_currencies")]
        public Dictionary<string, string> SettlementCurrencies { get; set; }
    }
}
