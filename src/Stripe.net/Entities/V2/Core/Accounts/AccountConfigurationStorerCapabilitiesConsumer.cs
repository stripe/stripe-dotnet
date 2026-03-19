// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorerCapabilitiesConsumer : StripeEntity<AccountConfigurationStorerCapabilitiesConsumer>
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe consumer FAs in USD.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public AccountConfigurationStorerCapabilitiesConsumerHoldsCurrencies HoldsCurrencies { get; set; }
    }
}
