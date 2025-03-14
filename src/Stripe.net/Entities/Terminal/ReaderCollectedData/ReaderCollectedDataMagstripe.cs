// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderCollectedDataMagstripe : StripeEntity<ReaderCollectedDataMagstripe>
    {
        /// <summary>
        /// The raw magstripe data collected by the reader.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif
        public string Data { get; set; }
    }
}
