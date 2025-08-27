// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceSettingsPaymentsPayoutsOptions : INestedOptions
    {
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
