// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationDeveloper : StripeEntity<AccountConfigurationDeveloper>
    {
        /// <summary>
        /// Indicates whether the Developer Configuration is active.
        /// </summary>
        [JsonProperty("applied")]
        [STJS.JsonPropertyName("applied")]
        public bool Applied { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Developer Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountConfigurationDeveloperCapabilities Capabilities { get; set; }
    }
}
