// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnrampSessionWalletAddressesDestinationTagsOptions : INestedOptions
    {
        [JsonProperty("stellar")]
        [STJS.JsonPropertyName("stellar")]
        public string Stellar { get; set; }
    }
}
