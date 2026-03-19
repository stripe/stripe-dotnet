// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationRecipientCapabilitiesBankAccountsOptions : INestedOptions
    {
        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over real time
        /// rails.
        /// </summary>
        [JsonProperty("instant")]
        [STJS.JsonPropertyName("instant")]
        public AccountCreateConfigurationRecipientCapabilitiesBankAccountsInstantOptions Instant { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over local
        /// networks.
        /// </summary>
        [JsonProperty("local")]
        [STJS.JsonPropertyName("local")]
        public AccountCreateConfigurationRecipientCapabilitiesBankAccountsLocalOptions Local { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over wire.
        /// </summary>
        [JsonProperty("wire")]
        [STJS.JsonPropertyName("wire")]
        public AccountCreateConfigurationRecipientCapabilitiesBankAccountsWireOptions Wire { get; set; }
    }
}
