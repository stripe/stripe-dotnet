// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationCardCreatorOptions : INestedOptions
    {
        /// <summary>
        /// Capabilities to request on the CardCreator Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountCreateConfigurationCardCreatorCapabilitiesOptions Capabilities { get; set; }
    }
}
