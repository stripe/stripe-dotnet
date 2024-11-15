// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestRequestOptions : INestedOptions
    {
        /// <summary>
        /// The body payload to send to the destination endpoint.
        /// </summary>
        [JsonProperty("body")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("body")]
#endif

        public string Body { get; set; }

        /// <summary>
        /// The headers to include in the forwarded request. Can be omitted if no additional headers
        /// (excluding Stripe-generated ones such as the Content-Type header) should be included.
        /// </summary>
        [JsonProperty("headers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("headers")]
#endif

        public List<RequestRequestHeaderOptions> Headers { get; set; }
    }
}
