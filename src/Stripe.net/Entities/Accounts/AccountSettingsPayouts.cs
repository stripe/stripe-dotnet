// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("debit_negative_balances")]
#endif

        public bool DebitNegativeBalances { get; set; }

        [JsonProperty("schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule")]
#endif

        public AccountSettingsPayoutsSchedule Schedule { get; set; }

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
