// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationStorerCapabilitiesConsumerOptions : INestedOptions
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe in a consumer financial account.
        /// </summary>
        [JsonProperty("holds_currencies")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("holds_currencies")]
#endif
        public AccountUpdateConfigurationStorerCapabilitiesConsumerHoldsCurrenciesOptions HoldsCurrencies { get; set; }
    }
}
