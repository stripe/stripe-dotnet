// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning.Catalog
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProviderListOptions : V2.ListOptions
    {
        /// <summary>
        /// Catalog partition to list providers from.
        /// One of: <c>dev</c>, <c>prod</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("catalog")]
        [STJS.JsonPropertyName("catalog")]
        public string Catalog { get; set; }

        /// <summary>
        /// When <c>true</c>, list development-only providers. When unset or <c>false</c>,
        /// development providers are excluded.
        /// </summary>
        [JsonProperty("development")]
        [STJS.JsonPropertyName("development")]
        public bool? Development { get; set; }
    }
}
