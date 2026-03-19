// File generated from our OpenAPI spec
namespace Stripe
{
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
    }
}
