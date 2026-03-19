// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The Redaction Job validation error object contains information about errors that affect
    /// the ability to redact a specific object in a redaction job.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RedactionJobValidationError : StripeEntity<RedactionJobValidationError>, IHasId, IHasObject
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
        /// A code indicating the reason for the error.
        /// One of: <c>invalid_cascading_source</c>, <c>invalid_file_purpose</c>,
        /// <c>invalid_state</c>, <c>locked_by_other_job</c>, or <c>too_many_objects</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// If the error is related to a specific object, this field includes the object's
        /// identifier and object type.
        /// </summary>
        [JsonProperty("erroring_object")]
        [STJS.JsonPropertyName("erroring_object")]
        public RedactionJobValidationErrorErroringObject ErroringObject { get; set; }

        /// <summary>
        /// A human-readable message providing more details about the error.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
