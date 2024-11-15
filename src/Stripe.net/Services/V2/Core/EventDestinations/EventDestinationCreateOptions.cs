// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventDestinationCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amazon EventBridge configuration.
        /// </summary>
        [JsonProperty("amazon_eventbridge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_eventbridge")]
#endif

        public EventDestinationCreateAmazonEventbridgeOptions AmazonEventbridge { get; set; }

        /// <summary>
        /// An optional description of what the event destination is used for.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        /// <summary>
        /// The list of events to enable for this endpoint.
        /// </summary>
        [JsonProperty("enabled_events")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled_events")]
#endif

        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Payload type of events being subscribed to.
        /// One of: <c>snapshot</c>, or <c>thin</c>.
        /// </summary>
        [JsonProperty("event_payload")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_payload")]
#endif

        public string EventPayload { get; set; }

        /// <summary>
        /// Where events should be routed from.
        /// One of: <c>other_accounts</c>, or <c>self</c>.
        /// </summary>
        [JsonProperty("events_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("events_from")]
#endif

        public List<string> EventsFrom { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>webhook_endpoint.signing_secret</c>, or <c>webhook_endpoint.url</c>.
        /// </summary>
        [JsonProperty("include")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include")]
#endif

        public List<string> Include { get; set; }

        /// <summary>
        /// Metadata.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Event destination name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        /// <summary>
        /// If using the snapshot event payload, the API version events are rendered as.
        /// </summary>
        [JsonProperty("snapshot_api_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("snapshot_api_version")]
#endif

        public string SnapshotApiVersion { get; set; }

        /// <summary>
        /// Event destination type.
        /// One of: <c>amazon_eventbridge</c>, or <c>webhook_endpoint</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        /// <summary>
        /// Webhook endpoint configuration.
        /// </summary>
        [JsonProperty("webhook_endpoint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("webhook_endpoint")]
#endif

        public EventDestinationCreateWebhookEndpointOptions WebhookEndpoint { get; set; }
    }
}
