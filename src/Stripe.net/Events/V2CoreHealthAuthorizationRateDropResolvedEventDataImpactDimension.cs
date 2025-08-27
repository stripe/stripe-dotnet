// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthAuthorizationRateDropResolvedEventDataImpactDimension : StripeEntity<V2CoreHealthAuthorizationRateDropResolvedEventDataImpactDimension>
    {
        /// <summary>
        /// The issuer dimension.
        /// </summary>
        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public string Issuer { get; set; }

        /// <summary>
        /// The type of the dimension.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
