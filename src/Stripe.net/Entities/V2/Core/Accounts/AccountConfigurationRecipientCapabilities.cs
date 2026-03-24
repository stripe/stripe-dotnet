// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationRecipientCapabilities : StripeEntity<AccountConfigurationRecipientCapabilities>
    {
        /// <summary>
        /// Capabilities that enable OutboundPayments to a bank account linked to this Account.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountConfigurationRecipientCapabilitiesBankAccounts BankAccounts { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to a linked debit card.
        /// </summary>
        [JsonProperty("cards")]
        [STJS.JsonPropertyName("cards")]
        public AccountConfigurationRecipientCapabilitiesCards Cards { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to a linked crypto wallet.
        /// </summary>
        [JsonProperty("crypto_wallets")]
        [STJS.JsonPropertyName("crypto_wallets")]
        public AccountConfigurationRecipientCapabilitiesCryptoWallets CryptoWallets { get; set; }

        /// <summary>
        /// Capabilities that enable the recipient to manage their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("stripe_balance")]
        [STJS.JsonPropertyName("stripe_balance")]
        public AccountConfigurationRecipientCapabilitiesStripeBalance StripeBalance { get; set; }
    }
}
