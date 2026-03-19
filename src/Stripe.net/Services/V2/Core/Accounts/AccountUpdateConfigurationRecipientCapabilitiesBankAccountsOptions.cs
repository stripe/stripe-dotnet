// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationRecipientCapabilitiesBankAccountsOptions : INestedOptions
    {
        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over local
        /// networks.
        /// </summary>
        [JsonProperty("local")]
        [STJS.JsonPropertyName("local")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsLocalOptions Local { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over wire.
        /// </summary>
        [JsonProperty("wire")]
        [STJS.JsonPropertyName("wire")]
        public AccountUpdateConfigurationRecipientCapabilitiesBankAccountsWireOptions Wire { get; set; }
    }
}
