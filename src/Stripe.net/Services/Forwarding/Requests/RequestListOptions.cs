// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestListOptions : ListOptions
    {
        /// <summary>
        /// Similar to other List endpoints, filters results based on created timestamp. You can
        /// pass gt, gte, lt, and lte timestamp values.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public RequestCreatedOptions Created { get; set; }
    }
}
