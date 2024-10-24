// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EventDestinationCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amazon EventBridge configuration.
        /// </summary>
        [JsonProperty("amazon_eventbridge")]
        public EventDestinationCreateAmazonEventbridgeOptions AmazonEventbridge { get; set; }

        /// <summary>
        /// An optional description of what the event destination is used for.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The list of events to enable for this endpoint.
        /// </summary>
        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Payload type of events being subscribed to.
        /// One of: <c>snapshot</c>, or <c>thin</c>.
        /// </summary>
        [JsonProperty("event_payload")]
        public string EventPayload { get; set; }

        /// <summary>
        /// Where events should be routed from.
        /// One of: <c>other_accounts</c>, or <c>self</c>.
        /// </summary>
        [JsonProperty("events_from")]
        public List<string> EventsFrom { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>webhook_endpoint.signing_secret</c>, or <c>webhook_endpoint.url</c>.
        /// </summary>
        [JsonProperty("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Event destination name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// If using the snapshot event payload, the API version events are rendered as.
        /// </summary>
        [JsonProperty("snapshot_api_version")]
        public string SnapshotApiVersion { get; set; }

        /// <summary>
        /// Event destination type.
        /// One of: <c>amazon_eventbridge</c>, or <c>webhook_endpoint</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Webhook endpoint configuration.
        /// </summary>
        [JsonProperty("webhook_endpoint")]
        public EventDestinationCreateWebhookEndpointOptions WebhookEndpoint { get; set; }
    }
}
