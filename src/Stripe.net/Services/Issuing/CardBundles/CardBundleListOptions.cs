// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardBundleListOptions : ListOptions
    {
        /// <summary>
        /// Only return card bundles with the given status.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>review</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Only return card bundles with the given type.
        /// One of: <c>custom</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
