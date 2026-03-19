// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreHealthAuthorizationRateDropResolvedEventDataImpactDimension : StripeEntity<V2CoreHealthAuthorizationRateDropResolvedEventDataImpactDimension>
    {
        /// <summary>
        /// The issuer dimension.
        /// </summary>
        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The type of the dimension.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
