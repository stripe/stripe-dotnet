// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationRecipientCapabilitiesBankAccounts : StripeEntity<AccountConfigurationRecipientCapabilitiesBankAccounts>
    {
        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over local
        /// networks.
        /// </summary>
        [JsonProperty("local")]
        [STJS.JsonPropertyName("local")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsLocal Local { get; set; }

        /// <summary>
        /// Enables this Account to receive OutboundPayments to linked bank accounts over wire.
        /// </summary>
        [JsonProperty("wire")]
        [STJS.JsonPropertyName("wire")]
        public AccountConfigurationRecipientCapabilitiesBankAccountsWire Wire { get; set; }
    }
}
