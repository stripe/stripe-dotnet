// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorerCapabilitiesConsumerHoldsCurrencies : StripeEntity<AccountConfigurationStorerCapabilitiesConsumerHoldsCurrencies>
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe consumer FAs in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountConfigurationStorerCapabilitiesConsumerHoldsCurrenciesUsd Usd { get; set; }
    }
}
