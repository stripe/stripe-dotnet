// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorerCapabilitiesOutboundPayments : StripeEntity<AccountConfigurationStorerCapabilitiesOutboundPayments>
    {
        /// <summary>
        /// Can send funds from a FinancialAccount to a bank account owned by a different entity.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountConfigurationStorerCapabilitiesOutboundPaymentsBankAccounts BankAccounts { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a debit card owned by a different entity.
        /// </summary>
        [JsonProperty("cards")]
        [STJS.JsonPropertyName("cards")]
        public AccountConfigurationStorerCapabilitiesOutboundPaymentsCards Cards { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a crypto wallet owned by a different entity.
        /// </summary>
        [JsonProperty("crypto_wallets")]
        [STJS.JsonPropertyName("crypto_wallets")]
        public AccountConfigurationStorerCapabilitiesOutboundPaymentsCryptoWallets CryptoWallets { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a FinancialAccount owned by a different
        /// entity.
        /// </summary>
        [JsonProperty("financial_accounts")]
        [STJS.JsonPropertyName("financial_accounts")]
        public AccountConfigurationStorerCapabilitiesOutboundPaymentsFinancialAccounts FinancialAccounts { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to someone else via paper check.
        /// </summary>
        [JsonProperty("paper_checks")]
        [STJS.JsonPropertyName("paper_checks")]
        public AccountConfigurationStorerCapabilitiesOutboundPaymentsPaperChecks PaperChecks { get; set; }
    }
}
