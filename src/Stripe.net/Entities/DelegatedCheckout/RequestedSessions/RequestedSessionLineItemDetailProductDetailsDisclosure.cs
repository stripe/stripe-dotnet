// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionLineItemDetailProductDetailsDisclosure : StripeEntity<RequestedSessionLineItemDetailProductDetailsDisclosure>
    {
        /// <summary>
        /// The content of the disclosure.
        /// </summary>
        [JsonProperty("content")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("content")]
#endif
        public string Content { get; set; }

        /// <summary>
        /// The content type of the disclosure.
        /// One of: <c>link</c>, <c>markdown</c>, or <c>plain</c>.
        /// </summary>
        [JsonProperty("content_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("content_type")]
#endif
        public string ContentType { get; set; }

        /// <summary>
        /// The type of disclosure.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
