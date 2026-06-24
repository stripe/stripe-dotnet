// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManager : StripeEntity<AccountConfigurationMoneyManager>
    {
        /// <summary>
        /// Indicates whether the money manager configuration is active. You cannot deactivate (or
        /// reactivate) the money manager configuration by updating this property.
        /// </summary>
        [JsonProperty("applied")]
        [STJS.JsonPropertyName("applied")]
        public bool Applied { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Money Manager Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountConfigurationMoneyManagerCapabilities Capabilities { get; set; }
    }
}
