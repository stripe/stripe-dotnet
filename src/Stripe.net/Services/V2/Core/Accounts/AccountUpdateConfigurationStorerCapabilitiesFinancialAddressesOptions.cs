// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationStorerCapabilitiesFinancialAddressesOptions : INestedOptions
    {
        /// <summary>
        /// Can provision a bank-account-like financial address (VBAN) to credit/debit a
        /// FinancialAccount.
        /// </summary>
        [JsonProperty("bank_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_accounts")]
#endif
        public AccountUpdateConfigurationStorerCapabilitiesFinancialAddressesBankAccountsOptions BankAccounts { get; set; }
    }
}
