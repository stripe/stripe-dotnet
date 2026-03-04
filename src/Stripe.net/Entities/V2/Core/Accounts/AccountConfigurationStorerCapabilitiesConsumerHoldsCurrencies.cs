// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationStorerCapabilitiesConsumerHoldsCurrencies : StripeEntity<AccountConfigurationStorerCapabilitiesConsumerHoldsCurrencies>
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe consumer FAs in USD.
        /// </summary>
        [JsonProperty("usd")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usd")]
#endif
        public AccountConfigurationStorerCapabilitiesConsumerHoldsCurrenciesUsd Usd { get; set; }
    }
}
