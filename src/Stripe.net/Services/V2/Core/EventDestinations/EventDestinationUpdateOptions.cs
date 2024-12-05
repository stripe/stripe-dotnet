// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EventDestinationUpdateOptions : BaseOptions, IHasMetadata
    {
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
        /// Additional fields to include in the response. Currently supports
        /// <c>webhook_endpoint.url</c>.
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
        /// Webhook endpoint configuration.
        /// </summary>
        [JsonProperty("webhook_endpoint")]
        public EventDestinationUpdateWebhookEndpointOptions WebhookEndpoint { get; set; }
    }
}
