// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationStorerCapabilitiesConsumerOptions : INestedOptions
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe in a consumer financial account.
        /// </summary>
        [JsonProperty("holds_currencies")]
        [STJS.JsonPropertyName("holds_currencies")]
        public AccountCreateConfigurationStorerCapabilitiesConsumerHoldsCurrenciesOptions HoldsCurrencies { get; set; }
    }
}
