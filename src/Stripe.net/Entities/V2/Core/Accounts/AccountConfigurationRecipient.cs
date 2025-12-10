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
        /// Indicates whether the recipient configuration is active. You can deactivate or
        /// reactivate the recipient configuration by updating this property. Deactivating the
        /// configuration by setting this value to false  unrequest all capabilities within the
        /// configuration. It will not delete any of the configuration's other properties.
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
    }
}
