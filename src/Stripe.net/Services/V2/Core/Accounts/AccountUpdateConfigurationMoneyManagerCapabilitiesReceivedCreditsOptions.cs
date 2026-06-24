// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOptions : INestedOptions
    {
        /// <summary>
        /// Can receive funds on a bank-account-like financial address (VBAN) to credit a
        /// FinancialAccount.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsBankAccountsOptions BankAccounts { get; set; }
    }
}
