// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Set up an event destination to receive events from Stripe across multiple destination
    /// types, including <a href="https://docs.stripe.com/webhooks">webhook endpoints</a> and <a
    /// href="https://docs.stripe.com/event-destinations/eventbridge">Amazon EventBridge</a>.
    /// Event destinations support receiving <a
    /// href="https://docs.stripe.com/api/v2/events">thin events</a> and <a
    /// href="https://docs.stripe.com/api/events">snapshot events</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EventDestination : StripeEntity<EventDestination>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Amazon EventBridge configuration.
        /// </summary>
        [JsonProperty("amazon_eventbridge")]
        [STJS.JsonPropertyName("amazon_eventbridge")]
        public EventDestinationAmazonEventbridge AmazonEventbridge { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

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
        /// Status. It can be set to either enabled or disabled.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional information about event destination status.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public EventDestinationStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Event destination type.
        /// One of: <c>amazon_eventbridge</c>, or <c>webhook_endpoint</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Time at which the object was last updated.
        /// </summary>
        [JsonProperty("updated")]
        [STJS.JsonPropertyName("updated")]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Webhook endpoint configuration.
        /// </summary>
        [JsonProperty("webhook_endpoint")]
        [STJS.JsonPropertyName("webhook_endpoint")]
        public EventDestinationWebhookEndpoint WebhookEndpoint { get; set; }
    }
}
