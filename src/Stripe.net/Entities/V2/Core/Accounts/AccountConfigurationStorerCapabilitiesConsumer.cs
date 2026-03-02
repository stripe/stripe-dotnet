// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationStorerCapabilitiesConsumer : StripeEntity<AccountConfigurationStorerCapabilitiesConsumer>
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe consumer FAs in USD.
        /// </summary>
        [JsonProperty("holds_currencies")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("holds_currencies")]
#endif
        public AccountConfigurationStorerCapabilitiesConsumerHoldsCurrencies HoldsCurrencies { get; set; }
    }
}
