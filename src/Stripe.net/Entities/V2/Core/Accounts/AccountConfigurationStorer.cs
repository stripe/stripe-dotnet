// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationStorer : StripeEntity<AccountConfigurationStorer>
    {
        /// <summary>
        /// Indicates whether the storer configuration is active. You cannot deactivate (or
        /// reactivate) the storer configuration by updating this property.
        /// </summary>
        [JsonProperty("applied")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied")]
#endif
        public bool Applied { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Storer Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capabilities")]
#endif
        public AccountConfigurationStorerCapabilities Capabilities { get; set; }
    }
}
