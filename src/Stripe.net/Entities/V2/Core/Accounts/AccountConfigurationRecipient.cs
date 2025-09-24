// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipient : StripeEntity<AccountConfigurationRecipient>
    {
        /// <summary>
        /// Represents the state of the configuration, and can be updated to deactivate or re-apply
        /// a configuration.
        /// </summary>
        [JsonProperty("applied")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied")]
#endif
        public bool Applied { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Recipient Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capabilities")]
#endif
        public AccountConfigurationRecipientCapabilities Capabilities { get; set; }

        /// <summary>
        /// The payout method to be used as a default outbound destination. This will allow the
        /// PayoutMethod to be omitted on OutboundPayments made through the dashboard or APIs.
        /// </summary>
        [JsonProperty("default_outbound_destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_outbound_destination")]
#endif
        public AccountConfigurationRecipientDefaultOutboundDestination DefaultOutboundDestination { get; set; }
    }
}
