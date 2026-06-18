// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesReceivedCredits : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesReceivedCredits>
    {
        /// <summary>
        /// Can receive credits to a bank-account like financial address to credit a
        /// FinancialAccount.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountConfigurationMoneyManagerCapabilitiesReceivedCreditsBankAccounts BankAccounts { get; set; }

        /// <summary>
        /// Can receive credits to a crypto wallet like financial address to credit a
        /// FinancialAccount.
        /// </summary>
        [JsonProperty("crypto_wallets")]
        [STJS.JsonPropertyName("crypto_wallets")]
        public AccountConfigurationMoneyManagerCapabilitiesReceivedCreditsCryptoWallets CryptoWallets { get; set; }
    }
}
