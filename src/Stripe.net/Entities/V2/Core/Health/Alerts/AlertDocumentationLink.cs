// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertDocumentationLink : StripeEntity<AlertDocumentationLink>
    {
        /// <summary>
        /// A human-readable label for the link.
        /// </summary>
        [JsonProperty("label")]
        [STJS.JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// The URL of the documentation.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
