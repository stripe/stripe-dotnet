// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipientCapabilities : StripeEntity<AccountConfigurationRecipientCapabilities>
    {
        /// <summary>
        /// Capabilities that enable OutboundPayments to a bank account linked to this Account.
        /// </summary>
        [JsonProperty("bank_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_accounts")]
#endif
        public AccountConfigurationRecipientCapabilitiesBankAccounts BankAccounts { get; set; }

        /// <summary>
        /// Capability that enable OutboundPayments to a debit card linked to this Account.
        /// </summary>
        [JsonProperty("cards")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cards")]
#endif
        public AccountConfigurationRecipientCapabilitiesCards Cards { get; set; }

        /// <summary>
        /// Capability that enable OutboundPayments to a crypto wallet linked to this Account.
        /// </summary>
        [JsonProperty("crypto_wallets")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto_wallets")]
#endif
        public AccountConfigurationRecipientCapabilitiesCryptoWallets CryptoWallets { get; set; }

        /// <summary>
        /// Capabilities that enable the recipient to manage their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("stripe_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_balance")]
#endif
        public AccountConfigurationRecipientCapabilitiesStripeBalance StripeBalance { get; set; }
    }
}
