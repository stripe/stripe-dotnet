// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestRequestHeaderOptions : INestedOptions
    {
        /// <summary>
        /// The header name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The header value.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
