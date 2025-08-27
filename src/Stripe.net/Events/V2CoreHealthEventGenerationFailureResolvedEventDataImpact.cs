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
        /// The account id the event should have been generated for. Only present when the account
        /// is a connected account.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The type of event that Stripe failed to generate.
        /// </summary>
        [JsonProperty("event_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_type")]
#endif
        public string EventType { get; set; }

        /// <summary>
        /// Indicates if the event was for livemode or not.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The number of webhooks that Stripe failed to create and deliver.
        /// </summary>
        [JsonProperty("missing_delivery_attempts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("missing_delivery_attempts")]
#endif
        public long MissingDeliveryAttempts { get; set; }

        /// <summary>
        /// The related object id.
        /// </summary>
        [JsonProperty("related_object_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object_id")]
#endif
        public string RelatedObjectId { get; set; }
    }
}
