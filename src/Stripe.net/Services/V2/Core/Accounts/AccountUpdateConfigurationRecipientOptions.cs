// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationRecipientOptions : INestedOptions
    {
        /// <summary>
        /// Represents the state of the configuration, and can be updated to deactivate or re-apply
        /// a configuration.
        /// </summary>
        [JsonProperty("applied")]
        [STJS.JsonPropertyName("applied")]
        public bool? Applied { get; set; }

        /// <summary>
        /// Capabilities to request on the Recipient Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountUpdateConfigurationRecipientCapabilitiesOptions Capabilities { get; set; }

        /// <summary>
        /// The payout method id to be used as a default outbound destination. This will allow the
        /// PayoutMethod to be omitted on OutboundPayments made through API or sending payouts via
        /// dashboard. Can also be explicitly set to <c>null</c> to clear the existing default
        /// outbound destination. For further details about creating an Outbound Destination, see <a
        /// href="https://docs.stripe.com/global-payouts-private-preview/quickstart?dashboard-or-api=api#collect-bank-account-details">Collect
        /// recipient's payment details</a>.
        /// </summary>
        [JsonProperty("default_outbound_destination")]
        [STJS.JsonPropertyName("default_outbound_destination")]
        public string DefaultOutboundDestination { get; set; }
    }
}
