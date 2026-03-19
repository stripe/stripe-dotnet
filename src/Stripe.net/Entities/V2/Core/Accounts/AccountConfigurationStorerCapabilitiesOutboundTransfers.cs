// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorerCapabilitiesOutboundTransfers : StripeEntity<AccountConfigurationStorerCapabilitiesOutboundTransfers>
    {
        /// <summary>
        /// Can send funds from a FinancialAccount to a bank account belonging to the same user.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountConfigurationStorerCapabilitiesOutboundTransfersBankAccounts BankAccounts { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a crypto wallet belonging to the same user.
        /// </summary>
        [JsonProperty("crypto_wallets")]
        [STJS.JsonPropertyName("crypto_wallets")]
        public AccountConfigurationStorerCapabilitiesOutboundTransfersCryptoWallets CryptoWallets { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to another FinancialAccount belonging to the same
        /// user.
        /// </summary>
        [JsonProperty("financial_accounts")]
        [STJS.JsonPropertyName("financial_accounts")]
        public AccountConfigurationStorerCapabilitiesOutboundTransfersFinancialAccounts FinancialAccounts { get; set; }
    }
}
