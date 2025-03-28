// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationRecipientOptions : INestedOptions
    {
        /// <summary>
        /// Capabilities to be requested on the Recipient Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capabilities")]
#endif
        public AccountCreateConfigurationRecipientCapabilitiesOptions Capabilities { get; set; }
    }
}
