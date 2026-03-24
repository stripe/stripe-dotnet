// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationStorerCapabilitiesConsumerHoldsCurrenciesOptions : INestedOptions
    {
        /// <summary>
        /// Can hold storage-type funds on Stripe in USD in a consumer financial account.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountUpdateConfigurationStorerCapabilitiesConsumerHoldsCurrenciesUsdOptions Usd { get; set; }
    }
}
