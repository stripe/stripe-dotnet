// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestResponseDetails : StripeEntity<RequestResponseDetails>
    {
        /// <summary>
        /// The response body from the destination endpoint to Stripe.
        /// </summary>
        [JsonProperty("body")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("body")]
#endif
        public string Body { get; set; }

        /// <summary>
        /// HTTP headers that the destination endpoint returned.
        /// </summary>
        [JsonProperty("headers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("headers")]
#endif
        public List<RequestResponseDetailsHeader> Headers { get; set; }

        /// <summary>
        /// The HTTP status code that the destination endpoint returned.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public long Status { get; set; }
    }
}
