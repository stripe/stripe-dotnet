// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderSetReaderDisplayOptions : BaseOptions
    {
        /// <summary>
        /// Cart.
        /// </summary>
        [JsonProperty("cart")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cart")]
#endif

        public ReaderCartOptions Cart { get; set; }

        /// <summary>
        /// Type.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
