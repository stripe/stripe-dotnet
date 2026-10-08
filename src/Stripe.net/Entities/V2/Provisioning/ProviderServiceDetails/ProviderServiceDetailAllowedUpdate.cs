// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderServiceDetailAllowedUpdate : StripeEntity<ProviderServiceDetailAllowedUpdate>
    {
        /// <summary>
        /// Whether the target service appears in upgrade flows, downgrade flows, or both.
        /// One of: <c>any</c>, <c>down</c>, or <c>up</c>.
        /// </summary>
        [JsonProperty("direction")]
        [STJS.JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Identifier of a service to which a resource can be updated.
        /// </summary>
        [JsonProperty("service")]
        [STJS.JsonPropertyName("service")]
        public string Service { get; set; }
    }
}
