// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationRecipient : StripeEntity<AccountConfigurationRecipient>
    {
        /// <summary>
        /// Indicates whether the recipient configuration is active. You can deactivate or
        /// reactivate the recipient configuration by updating this property. Deactivating the
        /// configuration by setting this value to false  unrequest all capabilities within the
        /// configuration. It will not delete any of the configuration's other properties.
        /// </summary>
        [JsonProperty("applied")]
        [STJS.JsonPropertyName("applied")]
        public bool Applied { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Recipient Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountConfigurationRecipientCapabilities Capabilities { get; set; }

        /// <summary>
        /// The payout method to be used as a default outbound destination. This will allow the
        /// PayoutMethod to be omitted on OutboundPayments made through the dashboard or APIs.
        /// </summary>
        [JsonProperty("default_outbound_destination")]
        [STJS.JsonPropertyName("default_outbound_destination")]
        public AccountConfigurationRecipientDefaultOutboundDestination DefaultOutboundDestination { get; set; }
    }
}
