// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsPayouts : StripeEntity<AccountSettingsPayouts>
    {
        /// <summary>
        /// A Boolean indicating if Stripe should try to reclaim negative balances from an attached
        /// bank account. See <a href="https://stripe.com/connect/account-balances">Understanding
        /// Connect account balances</a> for details. The default value is <c>false</c> when <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts, otherwise <c>true</c>.
        /// </summary>
        [JsonProperty("debit_negative_balances")]
        public bool DebitNegativeBalances { get; set; }

        [JsonProperty("schedule")]
        public AccountSettingsPayoutsSchedule Schedule { get; set; }

        /// <summary>
        /// The text that appears on the bank account statement for payouts. If not set, this
        /// defaults to the platform's bank descriptor as set in the Dashboard.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
