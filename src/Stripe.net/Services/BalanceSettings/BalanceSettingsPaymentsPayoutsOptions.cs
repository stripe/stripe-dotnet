// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceSettingsPaymentsPayoutsOptions : INestedOptions
    {
        /// <summary>
        /// The minimum balance amount to retain per currency after automatic payouts. Only funds
        /// that exceed these amounts are paid out. Learn more about the <a
        /// href="https://stripe.com/payouts/minimum-balances-for-automatic-payouts">minimum
        /// balances for automatic payouts</a>.
        /// </summary>
        [JsonProperty("minimum_balance_by_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum_balance_by_currency")]
#endif
        public Dictionary<string, long?> MinimumBalanceByCurrency { get; set; }

        /// <summary>
        /// Details on when funds from charges are available, and when they are paid out to an
        /// external account. For details, see our <a
        /// href="https://stripe.com/connect/bank-transfers#payout-information">Setting Bank and
        /// Debit Card Payouts</a> documentation.
        /// </summary>
        [JsonProperty("schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule")]
#endif
        public BalanceSettingsPaymentsPayoutsScheduleOptions Schedule { get; set; }

        /// <summary>
        /// The text that appears on the bank account statement for payouts. If not set, this
        /// defaults to the platform's bank descriptor as set in the Dashboard.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }
    }
}
