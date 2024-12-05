// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using Newtonsoft.Json;

    public class RequestRequestHeaderOptions : INestedOptions
    {
        /// <summary>
        /// The header name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The header value.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
