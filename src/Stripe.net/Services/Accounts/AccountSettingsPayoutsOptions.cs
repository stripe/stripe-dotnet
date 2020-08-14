namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsPayoutsOptions : INestedOptions
    {
        /// <summary>
        /// A Boolean indicating whether Stripe should try to reclaim negative balances from an
        /// attached bank account. For details, see <a
        /// href="https://stripe.com/docs/connect/account-balances">Understanding Connect Account
        /// Balances</a>.
        /// </summary>
        [JsonProperty("debit_negative_balances")]
        public bool? DebitNegativeBalances { get; set; }

        /// <summary>
        /// Details on when funds from charges are available, and when they are paid out to an
        /// external account. For details, see our <a
        /// href="https://stripe.com/docs/connect/bank-transfers#payout-information">Setting Bank
        /// and Debit Card Payouts</a> documentation.
        /// </summary>
        [JsonProperty("schedule")]
        public AccountSettingsPayoutsScheduleOptions Schedule { get; set; }

        /// <summary>
        /// The text that appears on the bank account statement for payouts. If not set, this
        /// defaults to the platform's bank descriptor as set in the Dashboard.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
