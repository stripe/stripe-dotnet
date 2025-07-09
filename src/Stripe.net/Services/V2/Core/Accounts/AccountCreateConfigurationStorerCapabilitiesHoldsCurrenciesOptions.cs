// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationStorerCapabilitiesHoldsCurrenciesOptions : INestedOptions
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe in GBP.
        /// </summary>
        [JsonProperty("gbp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gbp")]
#endif
        public AccountCreateConfigurationStorerCapabilitiesHoldsCurrenciesGbpOptions Gbp { get; set; }
    }
}
