// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCardCreator : StripeEntity<AccountConfigurationCardCreator>
    {
        /// <summary>
        /// Indicates whether the card_creator configuration is active. You can deactivate or
        /// reactivate the card_creator configuration by updating this property. Deactivating the
        /// configuration by setting this value to false will unrequest all capabilities within the
        /// configuration. It will not delete any of the configuration's other properties.
        /// </summary>
        [JsonProperty("applied")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied")]
#endif
        public bool Applied { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the CardCreator Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capabilities")]
#endif
        public AccountConfigurationCardCreatorCapabilities Capabilities { get; set; }
    }
}
