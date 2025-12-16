// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipientCapabilitiesBankAccounts : StripeEntity<AccountConfigurationRecipientCapabilitiesBankAccounts>
    {
        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over real time
        /// rails.
        /// </summary>
        [JsonProperty("instant")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("instant")]
#endif
        public AccountConfigurationRecipientCapabilitiesBankAccountsInstant Instant { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over local
        /// networks.
        /// </summary>
        [JsonProperty("local")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("local")]
#endif
        public AccountConfigurationRecipientCapabilitiesBankAccountsLocal Local { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over wire.
        /// </summary>
        [JsonProperty("wire")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wire")]
#endif
        public AccountConfigurationRecipientCapabilitiesBankAccountsWire Wire { get; set; }
    }
}
