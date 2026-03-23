// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The Redaction Job object redacts Stripe objects. You can use it to coordinate the
    /// removal of personal information from selected objects, making them permanently
    /// inaccessible in the Stripe Dashboard and API.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RedactionJob : StripeEntity<RedactionJob>, IHasId, IHasObject
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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The objects to redact in this job.
        /// </summary>
        [JsonProperty("objects")]
        [STJS.JsonPropertyName("objects")]
        public RedactionJobObjects Objects { get; set; }

        /// <summary>
        /// The status of the job.
        /// One of: <c>canceled</c>, <c>canceling</c>, <c>created</c>, <c>failed</c>, <c>ready</c>,
        /// <c>redacting</c>, <c>succeeded</c>, or <c>validating</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Validation behavior determines how a job validates objects for redaction eligibility.
        /// Default is <c>error</c>.
        /// One of: <c>error</c>, or <c>fix</c>.
        /// </summary>
        [JsonProperty("validation_behavior")]
        [STJS.JsonPropertyName("validation_behavior")]
        public string ValidationBehavior { get; set; }
    }
}
