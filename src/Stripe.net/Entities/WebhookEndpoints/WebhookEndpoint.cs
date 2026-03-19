// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// You can configure <a href="https://docs.stripe.com/webhooks/">webhook endpoints</a> via
    /// the API to be notified about events that happen in your Stripe account or connected
    /// accounts.
    ///
    /// Most users configure webhooks from <a href="https://dashboard.stripe.com/webhooks">the
    /// dashboard</a>, which provides a user interface for registering and testing your webhook
    /// endpoints.
    ///
    /// Related guide: <a href="https://docs.stripe.com/webhooks/configure">Setting up
    /// webhooks</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WebhookEndpoint : StripeEntity<WebhookEndpoint>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The API version events are rendered as for this webhook endpoint.
        /// </summary>
        [JsonProperty("api_version")]
        [STJS.JsonPropertyName("api_version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The ID of the associated Connect application.
        /// </summary>
        [JsonProperty("application")]
        [STJS.JsonPropertyName("application")]
        public string Application { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// An optional description of what the webhook is used for.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The list of events to enable for this endpoint. <c>['*']</c> indicates that all events
        /// are enabled, except those that require explicit selection.
        /// </summary>
        [JsonProperty("enabled_events")]
        [STJS.JsonPropertyName("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The endpoint's secret, used to generate <a
        /// href="https://docs.stripe.com/webhooks/signatures">webhook signatures</a>. Only returned
        /// at creation.
        /// </summary>
        [JsonProperty("secret")]
        [STJS.JsonPropertyName("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// The status of the webhook. It can be <c>enabled</c> or <c>disabled</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
