// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class EventDestinationCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amazon EventBridge configuration.
        /// </summary>
        [JsonProperty("amazon_eventbridge")]
        [STJS.JsonPropertyName("amazon_eventbridge")]
        public EventDestinationCreateAmazonEventbridgeOptions AmazonEventbridge { get; set; }

        /// <summary>
        /// An optional description of what the event destination is used for.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The list of events to enable for this endpoint.
        /// </summary>
        [JsonProperty("enabled_events")]
        [STJS.JsonPropertyName("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Payload type of events being subscribed to.
        /// One of: <c>snapshot</c>, or <c>thin</c>.
        /// </summary>
        [JsonProperty("event_payload")]
        [STJS.JsonPropertyName("event_payload")]
        public string EventPayload { get; set; }

        /// <summary>
        /// Specifies which accounts' events route to this destination. <c>@self</c>: Receive events
        /// from the account that owns the event destination. <c>@accounts</c>: Receive events
        /// emitted from other accounts you manage which includes your v1 and v2 accounts.
        /// <c>@organization_members</c>: Receive events from accounts directly linked to the
        /// organization. <c>@organization_members/@accounts</c>: Receive events from all accounts
        /// connected to any platform accounts in the organization.
        /// </summary>
        [JsonProperty("events_from")]
        [STJS.JsonPropertyName("events_from")]
        public List<string> EventsFrom { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>webhook_endpoint.signing_secret</c>, or <c>webhook_endpoint.url</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Event destination name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// If using the snapshot event payload, the API version events are rendered as.
        /// </summary>
        [JsonProperty("snapshot_api_version")]
        [STJS.JsonPropertyName("snapshot_api_version")]
        public string SnapshotApiVersion { get; set; }

        /// <summary>
        /// Event destination type.
        /// One of: <c>amazon_eventbridge</c>, or <c>webhook_endpoint</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Webhook endpoint configuration.
        /// </summary>
        [JsonProperty("webhook_endpoint")]
        [STJS.JsonPropertyName("webhook_endpoint")]
        public EventDestinationCreateWebhookEndpointOptions WebhookEndpoint { get; set; }
    }
}
