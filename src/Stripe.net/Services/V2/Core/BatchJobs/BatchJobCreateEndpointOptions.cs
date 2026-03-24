// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BatchJobCreateEndpointOptions : INestedOptions
    {
        /// <summary>
        /// The HTTP method to use when calling the endpoint.
        /// </summary>
        [JsonProperty("http_method")]
        [STJS.JsonPropertyName("http_method")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// The path of the endpoint to run this batch job against. In the form used in the
        /// documentation. For instance, for subscription migration this would be
        /// <c>/v1/subscriptions/:id/migrate</c>.
        /// </summary>
        [JsonProperty("path")]
        [STJS.JsonPropertyName("path")]
        public string Path { get; set; }
    }
}
