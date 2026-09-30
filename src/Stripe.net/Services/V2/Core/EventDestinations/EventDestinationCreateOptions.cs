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
        /// AWS account and region where Stripe creates the EventBridge partner event source.
        /// </summary>
        [JsonProperty("amazon_eventbridge")]
        [STJS.JsonPropertyName("amazon_eventbridge")]
        public EventDestinationCreateAmazonEventbridgeOptions AmazonEventbridge { get; set; }

        /// <summary>
        /// Azure subscription, resource group, and region where Stripe creates the partner topic.
        /// </summary>
        [JsonProperty("azure_event_grid")]
        [STJS.JsonPropertyName("azure_event_grid")]
        public EventDestinationCreateAzureEventGridOptions AzureEventGrid { get; set; }

        /// <summary>
        /// An optional user-defined description of the destination's purpose.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The list of event types enabled for delivery to this destination.
        /// </summary>
        [JsonProperty("enabled_events")]
        [STJS.JsonPropertyName("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Whether to deliver as snapshot or thin events.
        /// One of: <c>snapshot</c>, or <c>thin</c>.
        /// </summary>
        [JsonProperty("event_payload")]
        [STJS.JsonPropertyName("event_payload")]
        public string EventPayload { get; set; }

        /// <summary>
        /// The account or organization scopes that can supply events. Use this with
        /// <c>enabled_events</c> to define the subscription. <c>@self</c>: Receive events from the
        /// account that owns the event destination. <c>@accounts</c>: Receive events emitted from
        /// other accounts you manage, including your v1 and v2 accounts.
        /// <c>@organization_members</c>: Receive events from accounts directly linked to the
        /// organization. <c>@organization_members/@accounts</c>: Receive events from all accounts
        /// connected to any platform accounts in the organization.
        /// </summary>
        [JsonProperty("events_from")]
        [STJS.JsonPropertyName("events_from")]
        public List<string> EventsFrom { get; set; }

        /// <summary>
        /// Include normally redacted webhook fields in the create response. Public API clients must
        /// include <c>webhook_endpoint.signing_secret</c> to receive the signing secret.
        /// One of: <c>webhook_endpoint.signing_secret</c>, or <c>webhook_endpoint.url</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// User-defined key/value data for the destination.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A user-defined label for identifying the destination.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// For snapshot events only, the Stripe API version used to render event objects; do not
        /// provide this for thin events.
        /// </summary>
        [JsonProperty("snapshot_api_version")]
        [STJS.JsonPropertyName("snapshot_api_version")]
        public string SnapshotApiVersion { get; set; }

        /// <summary>
        /// The delivery transport. Chosen when the destination is created and cannot be changed by
        /// update.
        /// One of: <c>amazon_eventbridge</c>, <c>azure_event_grid</c>, or <c>webhook_endpoint</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Delivery target for the webhook endpoint. Live mode requires HTTPS; sandbox mode also
        /// supports HTTP.
        /// </summary>
        [JsonProperty("webhook_endpoint")]
        [STJS.JsonPropertyName("webhook_endpoint")]
        public EventDestinationCreateWebhookEndpointOptions WebhookEndpoint { get; set; }
    }
}
