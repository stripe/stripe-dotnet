// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

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
        /// Closed Enum. Namespace of events being subscribed to.
        /// One of: <c>v1</c>, or <c>v2</c>.
        /// </summary>
        [JsonProperty("event_namespace")]
        public string EventNamespace { get; set; }

        /// <summary>
        /// Open Enum. Where events should be routed from.
        /// One of: <c>accounts</c>, or <c>self</c>.
        /// </summary>
        [JsonProperty("events_from")]
        public List<string> EventsFrom { get; set; }

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
        /// Closed Enum. Status. It can be set to either enabled or disabled.
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
        /// Closed Enum. Event destination type.
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
        /// If using the v1 event namespace, the API version events are rendered as.
        /// </summary>
        [JsonProperty("v1_api_version")]
        public string V1ApiVersion { get; set; }

        /// <summary>
        /// Webhook endpoint configuration.
        /// </summary>
        [JsonProperty("webhook_endpoint")]
        public EventDestinationWebhookEndpoint WebhookEndpoint { get; set; }
    }
}
