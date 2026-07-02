// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OnrampSessionTransactionDetailsWalletAddressesDestinationTags : StripeEntity<OnrampSessionTransactionDetailsWalletAddressesDestinationTags>
    {
        /// <summary>
        /// A stellar destination tag.
        /// </summary>
        [JsonProperty("stellar")]
        [STJS.JsonPropertyName("stellar")]
        public string Stellar { get; set; }
    }
}
