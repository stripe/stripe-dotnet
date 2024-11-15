// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteFromQuoteOptions : INestedOptions
    {
        /// <summary>
        /// Whether this quote is a revision of the previous quote.
        /// </summary>
        [JsonProperty("is_revision")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_revision")]
#endif

        public bool? IsRevision { get; set; }

        /// <summary>
        /// The <c>id</c> of the quote that will be cloned.
        /// </summary>
        [JsonProperty("quote")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quote")]
#endif

        public string Quote { get; set; }
    }
}
