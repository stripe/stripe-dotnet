// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RequestResponseDetails : StripeEntity<RequestResponseDetails>
    {
        /// <summary>
        /// The response body from the destination endpoint to Stripe.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// HTTP headers that the destination endpoint returned.
        /// </summary>
        [JsonProperty("headers")]
        public List<RequestResponseDetailsHeader> Headers { get; set; }

        /// <summary>
        /// The HTTP status code that the destination endpoint returned.
        /// </summary>
        [JsonProperty("status")]
        public long Status { get; set; }
    }
}
