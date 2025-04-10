// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Redaction Jobs store the status of a redaction request. They are created when a
    /// redaction request is made and track the redaction validation and execution.
    /// </summary>
    public class RedactionJob : StripeEntity<RedactionJob>, IHasId, IHasObject
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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The objects at the root level that are subject to redaction.
        /// </summary>
        [JsonProperty("objects")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("objects")]
#endif
        public RedactionJobRootObjects Objects { get; set; }

        /// <summary>
        /// The status field represents the current state of the redaction job. It can take on any
        /// of the following values: VALIDATING, READY, REDACTING, SUCCEEDED, CANCELED, FAILED.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Default is "error". If "error", we will make sure all objects in the graph are
        /// redactable in the 1st traversal, otherwise error. If "fix", where possible, we will
        /// auto-fix any validation errors (e.g. by auto-transitioning objects to a terminal state,
        /// etc.) in the 2nd traversal before redacting.
        /// </summary>
        [JsonProperty("validation_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validation_behavior")]
#endif
        public string ValidationBehavior { get; set; }
    }
}
