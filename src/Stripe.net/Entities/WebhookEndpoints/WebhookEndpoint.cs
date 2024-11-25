// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
    public class WebhookEndpoint : StripeEntity<WebhookEndpoint>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// The API version events are rendered as for this webhook endpoint.
        /// </summary>
        [JsonProperty("api_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("api_version")]
#endif

        public string ApiVersion { get; set; }

        /// <summary>
        /// The ID of the associated Connect application.
        /// </summary>
        [JsonProperty("application")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application")]
#endif

        public string Application { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif

        public bool? Deleted { get; set; }

        /// <summary>
        /// An optional description of what the webhook is used for.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        /// <summary>
        /// The list of events to enable for this endpoint. <c>['*']</c> indicates that all events
        /// are enabled, except those that require explicit selection.
        /// </summary>
        [JsonProperty("enabled_events")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled_events")]
#endif

        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The endpoint's secret, used to generate <a
        /// href="https://docs.stripe.com/webhooks/signatures">webhook signatures</a>. Only returned
        /// at creation.
        /// </summary>
        [JsonProperty("secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secret")]
#endif

        public string Secret { get; set; }

        /// <summary>
        /// The status of the webhook. It can be <c>enabled</c> or <c>disabled</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif

        public string Url { get; set; }
    }
}
