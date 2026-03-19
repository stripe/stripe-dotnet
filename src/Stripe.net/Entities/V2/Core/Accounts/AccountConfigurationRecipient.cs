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
    }
}
