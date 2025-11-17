// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthEventGenerationFailureResolvedEventDataImpact : StripeEntity<V2CoreHealthEventGenerationFailureResolvedEventDataImpact>
    {
        /// <summary>
        /// The context the event should have been generated for. Only present when the account is a
        /// connected account.
        /// </summary>
        [JsonProperty("context")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("context")]
#endif
        public string Context { get; set; }

        /// <summary>
        /// The type of event that Stripe failed to generate.
        /// </summary>
        [JsonProperty("event_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_type")]
#endif
        public string EventType { get; set; }

        /// <summary>
        /// The related object details.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif
        public V2CoreHealthEventGenerationFailureResolvedEventDataImpactRelatedObject RelatedObject { get; set; }
    }
}
