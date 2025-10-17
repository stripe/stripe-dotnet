// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationCardCreatorOptions : INestedOptions
    {
        /// <summary>
        /// Capabilities to request on the CardCreator Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capabilities")]
#endif
        public AccountCreateConfigurationCardCreatorCapabilitiesOptions Capabilities { get; set; }
    }
}
