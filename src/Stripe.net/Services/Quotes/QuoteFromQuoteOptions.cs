// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QuoteFromQuoteOptions : INestedOptions
    {
        /// <summary>
        /// Whether this quote is a revision of the previous quote.
        /// </summary>
        [JsonProperty("is_revision")]
        [STJS.JsonPropertyName("is_revision")]
        public bool? IsRevision { get; set; }

        /// <summary>
        /// The <c>id</c> of the quote that will be cloned.
        /// </summary>
        [JsonProperty("quote")]
        [STJS.JsonPropertyName("quote")]
        public string Quote { get; set; }
    }
}
