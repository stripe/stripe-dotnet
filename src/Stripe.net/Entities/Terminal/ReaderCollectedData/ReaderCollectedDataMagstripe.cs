// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderCollectedDataMagstripe : StripeEntity<ReaderCollectedDataMagstripe>
    {
        /// <summary>
        /// The raw magstripe data collected by the reader.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
