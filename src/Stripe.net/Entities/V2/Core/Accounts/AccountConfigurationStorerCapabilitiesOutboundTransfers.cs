// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationStorerCapabilitiesOutboundTransfers : StripeEntity<AccountConfigurationStorerCapabilitiesOutboundTransfers>
    {
        /// <summary>
        /// Can send funds from a FinancialAccount, to a bank account, owned by yourself.
        /// </summary>
        [JsonProperty("bank_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_accounts")]
#endif
        public AccountConfigurationStorerCapabilitiesOutboundTransfersBankAccounts BankAccounts { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a crypto wallet, owned by yourself.
        /// </summary>
        [JsonProperty("crypto_wallets")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto_wallets")]
#endif
        public AccountConfigurationStorerCapabilitiesOutboundTransfersCryptoWallets CryptoWallets { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to another FinancialAccount, owned by yourself.
        /// </summary>
        [JsonProperty("financial_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_accounts")]
#endif
        public AccountConfigurationStorerCapabilitiesOutboundTransfersFinancialAccounts FinancialAccounts { get; set; }
    }
}
