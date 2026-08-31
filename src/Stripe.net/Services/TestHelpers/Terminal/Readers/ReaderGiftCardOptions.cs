// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderGiftCardOptions : INestedOptions
    {
        /// <summary>
        /// The brand of the gift card.
        /// One of: <c>svs</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Simulated track 2 data for the gift card payment method.
        /// </summary>
        [JsonProperty("track_2")]
        [STJS.JsonPropertyName("track_2")]
        public string Track2 { get; set; }
    }
}
