// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceSettingsPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// A Boolean indicating whether Stripe should try to reclaim negative balances from an
        /// attached bank account. For details, see <a
        /// href="https://stripe.com/connect/account-balances">Understanding Connect Account
        /// Balances</a>.
        /// </summary>
        [JsonProperty("debit_negative_balances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("debit_negative_balances")]
#endif
        public bool? DebitNegativeBalances { get; set; }

        /// <summary>
        /// Settings specific to the account's payouts.
        /// </summary>
        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public BalanceSettingsPaymentsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Settings related to the account's balance settlement timing.
        /// </summary>
        [JsonProperty("settlement_timing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settlement_timing")]
#endif
        public BalanceSettingsPaymentsSettlementTimingOptions SettlementTiming { get; set; }
    }
}
