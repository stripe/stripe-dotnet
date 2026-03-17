// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BatchJobCreateEndpointOptions : INestedOptions
    {
        /// <summary>
        /// The HTTP method to use when calling the endpoint.
        /// </summary>
        [JsonProperty("http_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("http_method")]
#endif
        public string HttpMethod { get; set; }

        /// <summary>
        /// The path of the endpoint to run this batch job against. In the form used in the
        /// documentation. For instance, for subscription migration this would be
        /// <c>/v1/subscriptions/:id/migrate</c>.
        /// </summary>
        [JsonProperty("path")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("path")]
#endif
        public string Path { get; set; }
    }
}
