// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Set up an event destination to receive events from Stripe across multiple destination
    /// types, including <a href="https://docs.stripe.com/webhooks">webhook endpoints</a> and <a
    /// href="https://docs.stripe.com/event-destinations/eventbridge">Amazon EventBridge</a>.
    /// Event destinations support receiving <a
    /// href="https://docs.stripe.com/api/v2/events">thin events</a> and <a
    /// href="https://docs.stripe.com/api/events">snapshot events</a>.
    /// </summary>
    public class EventDestination : StripeEntity<EventDestination>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Amazon EventBridge configuration.
        /// </summary>
        [JsonProperty("amazon_eventbridge")]
        public EventDestinationAmazonEventbridge AmazonEventbridge { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

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
        /// Status. It can be set to either enabled or disabled.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional information about event destination status.
        /// </summary>
        [JsonProperty("status_details")]
        public EventDestinationStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Event destination type.
        /// One of: <c>amazon_eventbridge</c>, or <c>webhook_endpoint</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Time at which the object was last updated.
        /// </summary>
        [JsonProperty("updated")]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Webhook endpoint configuration.
        /// </summary>
        [JsonProperty("webhook_endpoint")]
        public EventDestinationWebhookEndpoint WebhookEndpoint { get; set; }
    }
}
