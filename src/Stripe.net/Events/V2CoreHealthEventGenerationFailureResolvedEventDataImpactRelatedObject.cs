// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2CoreHealthEventGenerationFailureResolvedEventDataImpactRelatedObject : StripeEntity<V2CoreHealthEventGenerationFailureResolvedEventDataImpactRelatedObject>,
        IHasId
    {
        /// <summary>
        /// The ID of the related object (e.g., "pi_...").
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of the related object (e.g., "payment_intent").
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The API URL for the related object (e.g., "/v1/payment_intents/pi_...").
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
