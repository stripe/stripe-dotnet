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
        /// One of: <c>any</c>, <c>down</c>, or <c>up</c>.
        /// </summary>
        [JsonProperty("direction")]
        [STJS.JsonPropertyName("direction")]
        public string Direction { get; set; }

        [JsonProperty("service")]
        [STJS.JsonPropertyName("service")]
        public string Service { get; set; }
    }
}
