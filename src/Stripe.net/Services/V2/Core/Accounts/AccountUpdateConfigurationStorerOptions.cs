// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationStorerOptions : INestedOptions
    {
        /// <summary>
        /// Represents the state of the configuration, and can be updated to deactivate or re-apply
        /// a configuration.
        /// </summary>
        [JsonProperty("applied")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied")]
#endif
        public bool? Applied { get; set; }

        /// <summary>
        /// Capabilities to request on the Storer Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capabilities")]
#endif
        public AccountUpdateConfigurationStorerCapabilitiesOptions Capabilities { get; set; }
    }
}
