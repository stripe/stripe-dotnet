// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationStorerCapabilitiesOutboundPayments : StripeEntity<AccountConfigurationStorerCapabilitiesOutboundPayments>
    {
        /// <summary>
        /// Can send funds from a FinancialAccount to a bank account owned by a different entity.
        /// </summary>
        [JsonProperty("bank_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_accounts")]
#endif
        public AccountConfigurationStorerCapabilitiesOutboundPaymentsBankAccounts BankAccounts { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a debit card owned by a different entity.
        /// </summary>
        [JsonProperty("cards")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cards")]
#endif
        public AccountConfigurationStorerCapabilitiesOutboundPaymentsCards Cards { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a crypto wallet owned by a different entity.
        /// </summary>
        [JsonProperty("crypto_wallets")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto_wallets")]
#endif
        public AccountConfigurationStorerCapabilitiesOutboundPaymentsCryptoWallets CryptoWallets { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a FinancialAccount owned by a different
        /// entity.
        /// </summary>
        [JsonProperty("financial_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_accounts")]
#endif
        public AccountConfigurationStorerCapabilitiesOutboundPaymentsFinancialAccounts FinancialAccounts { get; set; }
    }
}
