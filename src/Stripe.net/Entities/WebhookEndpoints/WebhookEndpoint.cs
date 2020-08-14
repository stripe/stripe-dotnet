namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class WebhookEndpoint : StripeEntity<WebhookEndpoint>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The API version events are rendered as for this webhook endpoint.
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The ID of the associated Connect application.
        /// </summary>
        [JsonProperty("application")]
        public string Application { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// An optional description of what the webhook is used for.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The list of events to enable for this endpoint. <c>['*']</c> indicates that all events
        /// are enabled, except those that require explicit selection.
        /// </summary>
        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The endpoint's secret, used to generate <a
        /// href="https://stripe.com/docs/webhooks/signatures">webhook signatures</a>. Only returned
        /// at creation.
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// The status of the webhook. It can be <c>enabled</c> or <c>disabled</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
