// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthEventGenerationFailureResolvedEventDataImpactRelatedObject : StripeEntity<V2CoreHealthEventGenerationFailureResolvedEventDataImpactRelatedObject>,
        IHasId
    {
        /// <summary>
        /// The ID of the related object (e.g., "pi_...").
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The type of the related object (e.g., "payment_intent").
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The API URL for the related object (e.g., "/v1/payment_intents/pi_...").
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
