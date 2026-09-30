// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class EventDestinationUpdateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// An optional user-defined description of the destination's purpose; it does not control
        /// routing.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The list of event types enabled for delivery to this destination. Event scopes are
        /// configured when the destination is created.
        /// </summary>
        [JsonProperty("enabled_events")]
        [STJS.JsonPropertyName("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Include the normally redacted <c>webhook_endpoint.url</c> in the response.
        /// One of: <c>webhook_endpoint.url</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        [STJS.JsonConverter(typeof(STJNullPreservingDictionaryConverter))]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A user-defined label for identifying the destination; it does not control routing.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// New delivery target for the webhook endpoint. Live mode requires HTTPS; sandbox mode
        /// also supports HTTP.
        /// </summary>
        [JsonProperty("webhook_endpoint")]
        [STJS.JsonPropertyName("webhook_endpoint")]
        public EventDestinationUpdateWebhookEndpointOptions WebhookEndpoint { get; set; }
    }
}
