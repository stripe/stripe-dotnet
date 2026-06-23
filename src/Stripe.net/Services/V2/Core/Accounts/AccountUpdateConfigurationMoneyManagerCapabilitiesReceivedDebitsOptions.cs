// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedDebitsOptions : INestedOptions
    {
        /// <summary>
        /// Can receive debits to a FinancialAccount from a bank account.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedDebitsBankAccountsOptions BankAccounts { get; set; }
    }
}
