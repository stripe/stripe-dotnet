// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsEventDestinationNewConfiguration : StripeEntity<ActivityLogDetailsEventDestinationNewConfiguration>
    {
        /// <summary>
        /// Amazon EventBridge configuration.
        /// </summary>
        [JsonProperty("amazon_eventbridge")]
        [STJS.JsonPropertyName("amazon_eventbridge")]
        public ActivityLogDetailsEventDestinationNewConfigurationAmazonEventbridge AmazonEventbridge { get; set; }

        /// <summary>
        /// Azure Event Grid configuration.
        /// </summary>
        [JsonProperty("azure_event_grid")]
        [STJS.JsonPropertyName("azure_event_grid")]
        public ActivityLogDetailsEventDestinationNewConfigurationAzureEventGrid AzureEventGrid { get; set; }

        /// <summary>
        /// Event types subscribed to by the destination. ["*"] subscribes to all V1 webhook events.
        /// </summary>
        [JsonProperty("enabled_events")]
        [STJS.JsonPropertyName("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Event source selectors: @self, @accounts, @organization_members, or
        /// @organization_members/@accounts.
        /// </summary>
        [JsonProperty("events_from")]
        [STJS.JsonPropertyName("events_from")]
        public List<string> EventsFrom { get; set; }

        /// <summary>
        /// Status of the event destination.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Webhook endpoint configuration.
        /// </summary>
        [JsonProperty("webhook_endpoint")]
        [STJS.JsonPropertyName("webhook_endpoint")]
        public ActivityLogDetailsEventDestinationNewConfigurationWebhookEndpoint WebhookEndpoint { get; set; }
    }
}
