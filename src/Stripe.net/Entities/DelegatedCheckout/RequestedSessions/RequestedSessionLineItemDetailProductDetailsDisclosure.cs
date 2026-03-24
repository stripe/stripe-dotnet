// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionLineItemDetailProductDetailsDisclosure : StripeEntity<RequestedSessionLineItemDetailProductDetailsDisclosure>
    {
        /// <summary>
        /// The content of the disclosure.
        /// </summary>
        [JsonProperty("content")]
        [STJS.JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// The content type of the disclosure.
        /// One of: <c>link</c>, <c>markdown</c>, or <c>plain</c>.
        /// </summary>
        [JsonProperty("content_type")]
        [STJS.JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// The type of disclosure.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
