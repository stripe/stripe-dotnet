// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationRecipientCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Capabilities that enable OutboundPayments to a bank account linked to this Account.
        /// </summary>
        [JsonProperty("bank_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_accounts")]
#endif
        public AccountCreateConfigurationRecipientCapabilitiesBankAccountsOptions BankAccounts { get; set; }

        /// <summary>
        /// Capabilities that enable OutboundPayments to a card linked to this Account.
        /// </summary>
        [JsonProperty("cards")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cards")]
#endif
        public AccountCreateConfigurationRecipientCapabilitiesCardsOptions Cards { get; set; }

        /// <summary>
        /// Capabilities that enable the recipient to manage their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("stripe_balance")]
        [STJS.JsonPropertyName("stripe_balance")]
        public AccountCreateConfigurationRecipientCapabilitiesStripeBalanceOptions StripeBalance { get; set; }
    }
}
