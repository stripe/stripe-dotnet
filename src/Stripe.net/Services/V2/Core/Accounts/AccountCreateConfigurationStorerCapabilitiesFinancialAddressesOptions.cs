// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationStorerCapabilitiesFinancialAddressesOptions : INestedOptions
    {
        /// <summary>
        /// Can provision a bank-account-like financial address (VBAN) to credit/debit a
        /// FinancialAccount.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountCreateConfigurationStorerCapabilitiesFinancialAddressesBankAccountsOptions BankAccounts { get; set; }

        /// <summary>
        /// Can provision a crypto wallet like financial address to credit a FinancialAccount.
        /// </summary>
        [JsonProperty("crypto_wallets")]
        [STJS.JsonPropertyName("crypto_wallets")]
        public AccountCreateConfigurationStorerCapabilitiesFinancialAddressesCryptoWalletsOptions CryptoWallets { get; set; }
    }
}
