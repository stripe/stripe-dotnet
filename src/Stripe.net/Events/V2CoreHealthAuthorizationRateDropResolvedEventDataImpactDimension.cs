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
        /// The acquirer dimension.
        /// </summary>
        [JsonProperty("acquirer")]
        [STJS.JsonPropertyName("acquirer")]
        public string Acquirer { get; set; }

        /// <summary>
        /// The issuer dimension.
        /// </summary>
        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The type of the dimension.
        /// One of: <c>acquirer</c>, or <c>issuer</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
