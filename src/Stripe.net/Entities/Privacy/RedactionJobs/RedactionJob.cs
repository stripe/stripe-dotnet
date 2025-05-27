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
    /// The Redaction Job object redacts Stripe objects. You can use it to coordinate the
    /// removal of personal information from selected objects, making them permanently
    /// inaccessible in the Stripe Dashboard and API.
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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The objects to redact in this job.
        /// </summary>
        [JsonProperty("objects")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("objects")]
#endif
        public RedactionJobObjects Objects { get; set; }

        /// <summary>
        /// The status of the job.
        /// One of: <c>canceled</c>, <c>canceling</c>, <c>created</c>, <c>failed</c>, <c>ready</c>,
        /// <c>redacting</c>, <c>succeeded</c>, or <c>validating</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Validation behavior determines how a job validates objects for redaction eligibility.
        /// Default is <c>error</c>.
        /// One of: <c>error</c>, or <c>fix</c>.
        /// </summary>
        [JsonProperty("validation_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validation_behavior")]
#endif
        public string ValidationBehavior { get; set; }
    }
}
