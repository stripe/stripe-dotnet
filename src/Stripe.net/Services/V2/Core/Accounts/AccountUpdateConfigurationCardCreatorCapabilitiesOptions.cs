// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationCardCreatorCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Can create cards for commercial issuing use cases.
        /// </summary>
        [JsonProperty("commercial")]
        [STJS.JsonPropertyName("commercial")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialOptions Commercial { get; set; }

        /// <summary>
        /// Can create cards for consumer issuing use cases.
        /// </summary>
        [JsonProperty("consumer")]
        [STJS.JsonPropertyName("consumer")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesConsumerOptions Consumer { get; set; }
    }
}
