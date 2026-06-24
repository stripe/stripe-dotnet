// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Can send funds from a FinancialAccount to a bank account owned by yourself.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersBankAccountsOptions BankAccounts { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a crypto wallet owned by yourself.
        /// </summary>
        [JsonProperty("crypto_wallets")]
        [STJS.JsonPropertyName("crypto_wallets")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersCryptoWalletsOptions CryptoWallets { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to another FinancialAccount owned by yourself.
        /// </summary>
        [JsonProperty("financial_accounts")]
        [STJS.JsonPropertyName("financial_accounts")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesOutboundTransfersFinancialAccountsOptions FinancialAccounts { get; set; }
    }
}
