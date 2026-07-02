// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnrampSessionWalletAddressesOptions : INestedOptions
    {
        /// <summary>
        /// The end customer's crypto wallet destination tag (for each network) to use for this
        /// transaction. This only applies for tag-based assets such as XLM.
        ///
        /// * When left null, the user enters their wallet in the onramp UI.
        /// </summary>
        [JsonProperty("destination_tags")]
        [STJS.JsonPropertyName("destination_tags")]
        public OnrampSessionWalletAddressesDestinationTagsOptions DestinationTags { get; set; }
    }
}
