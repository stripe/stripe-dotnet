// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RequestRequestDetails : StripeEntity<RequestRequestDetails>
    {
        /// <summary>
        /// The body payload to send to the destination endpoint.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// The headers to include in the forwarded request. Can be omitted if no additional headers
        /// (excluding Stripe-generated ones such as the Content-Type header) should be included.
        /// </summary>
        [JsonProperty("headers")]
        public List<RequestRequestDetailsHeader> Headers { get; set; }

        /// <summary>
        /// The HTTP method used to call the destination endpoint.
        /// </summary>
        [JsonProperty("http_method")]
        public string HttpMethod { get; set; }
    }
}
