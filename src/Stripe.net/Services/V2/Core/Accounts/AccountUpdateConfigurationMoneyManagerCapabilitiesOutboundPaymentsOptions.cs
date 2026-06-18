// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Can send funds from a FinancialAccount to a bank account owned by someone else.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsBankAccountsOptions BankAccounts { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a debit card owned by someone else.
        /// </summary>
        [JsonProperty("cards")]
        [STJS.JsonPropertyName("cards")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsCardsOptions Cards { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to a crypto wallet owned by someone else.
        /// </summary>
        [JsonProperty("crypto_wallets")]
        [STJS.JsonPropertyName("crypto_wallets")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsCryptoWalletsOptions CryptoWallets { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to another FinancialAccount owned by someone
        /// else.
        /// </summary>
        [JsonProperty("financial_accounts")]
        [STJS.JsonPropertyName("financial_accounts")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsFinancialAccountsOptions FinancialAccounts { get; set; }

        /// <summary>
        /// Can send funds from a FinancialAccount to someone else via paper check.
        /// </summary>
        [JsonProperty("paper_checks")]
        [STJS.JsonPropertyName("paper_checks")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesOutboundPaymentsPaperChecksOptions PaperChecks { get; set; }
    }
}
