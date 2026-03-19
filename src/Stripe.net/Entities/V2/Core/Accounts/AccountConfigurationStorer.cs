// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorer : StripeEntity<AccountConfigurationStorer>
    {
        /// <summary>
        /// Indicates whether the storer configuration is active. You cannot deactivate (or
        /// reactivate) the storer configuration by updating this property.
        /// </summary>
        [JsonProperty("applied")]
        [STJS.JsonPropertyName("applied")]
        public bool Applied { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Storer Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountConfigurationStorerCapabilities Capabilities { get; set; }
    }
}
