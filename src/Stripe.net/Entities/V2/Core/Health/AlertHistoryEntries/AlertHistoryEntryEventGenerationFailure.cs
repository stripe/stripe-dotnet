// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertHistoryEntryEventGenerationFailure : StripeEntity<AlertHistoryEntryEventGenerationFailure>
    {
        /// <summary>
        /// The context the event should have been generated for. Only present when the account is a
        /// connected account.
        /// </summary>
        [JsonProperty("context")]
        [STJS.JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// The type of event that Stripe failed to generate.
        /// </summary>
        [JsonProperty("event_type")]
        [STJS.JsonPropertyName("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// The related object details.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]
        public AlertHistoryEntryEventGenerationFailureRelatedObject RelatedObject { get; set; }
    }
}
