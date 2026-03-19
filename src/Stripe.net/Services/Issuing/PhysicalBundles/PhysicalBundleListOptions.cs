// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PhysicalBundleListOptions : ListOptions
    {
        /// <summary>
        /// Only return physical bundles with the given status.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>review</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Only return physical bundles with the given type.
        /// One of: <c>custom</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
