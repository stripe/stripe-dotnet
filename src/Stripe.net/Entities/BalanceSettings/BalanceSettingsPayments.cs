// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BalanceSettingsPayments : StripeEntity<BalanceSettingsPayments>
    {
        /// <summary>
        /// A Boolean indicating if Stripe should try to reclaim negative balances from an attached
        /// bank account. See <a href="https://stripe.com/connect/account-balances">Understanding
        /// Connect account balances</a> for details. The default value is <c>false</c> when <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts, otherwise <c>true</c>.
        /// </summary>
        [JsonProperty("debit_negative_balances")]
        [STJS.JsonPropertyName("debit_negative_balances")]
        public bool? DebitNegativeBalances { get; set; }

        /// <summary>
        /// Settings specific to the account's payouts.
        /// </summary>
        [JsonProperty("payouts")]
        [STJS.JsonPropertyName("payouts")]
        public BalanceSettingsPaymentsPayouts Payouts { get; set; }

        [JsonProperty("settlement_timing")]
        [STJS.JsonPropertyName("settlement_timing")]
        public BalanceSettingsPaymentsSettlementTiming SettlementTiming { get; set; }

        /// <summary>
        /// The default settlement currency for the account.
        /// </summary>
        [JsonProperty("default_settlement_currency")]
        [STJS.JsonPropertyName("default_settlement_currency")]
        public string DefaultSettlementCurrency { get; set; }

        /// <summary>
        /// A hash of settlement currencies and their states. Each key is an ISO 4217 currency code,
        /// and the value is one of <c>enabled</c>, <c>disabled</c>, or
        /// <c>restricted_by_application</c>.
        /// One of: <c>disabled</c>, <c>enabled</c>, or <c>restricted_by_application</c>.
        /// </summary>
        [JsonProperty("settlement_currencies")]
        [STJS.JsonPropertyName("settlement_currencies")]
        public Dictionary<string, string> SettlementCurrencies { get; set; }
    }
}
