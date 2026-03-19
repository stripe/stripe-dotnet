// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationCardCreatorCapabilities : StripeEntity<AccountConfigurationCardCreatorCapabilities>
    {
        /// <summary>
        /// Can create cards for commercial issuing use cases.
        /// </summary>
        [JsonProperty("commercial")]
        [STJS.JsonPropertyName("commercial")]
        public AccountConfigurationCardCreatorCapabilitiesCommercial Commercial { get; set; }

        /// <summary>
        /// Can create cards for consumer issuing use cases.
        /// </summary>
        [JsonProperty("consumer")]
        [STJS.JsonPropertyName("consumer")]
        public AccountConfigurationCardCreatorCapabilitiesConsumer Consumer { get; set; }
    }
}
