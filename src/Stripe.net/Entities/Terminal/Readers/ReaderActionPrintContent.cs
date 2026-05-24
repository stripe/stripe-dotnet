// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionPrintContent : StripeEntity<ReaderActionPrintContent>
    {
        /// <summary>
        /// Metadata of an uploaded file.
        /// </summary>
        [JsonProperty("image")]
        [STJS.JsonPropertyName("image")]
        public ReaderActionPrintContentImage Image { get; set; }

        /// <summary>
        /// The type of content to print. Currently supports <c>image</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
