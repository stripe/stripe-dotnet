// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Validation errors.
    /// </summary>
    public class RedactionJobValidationError : StripeEntity<RedactionJobValidationError>, IHasId, IHasObject
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
        /// One of: <c>invalid_cascading_source</c>, <c>invalid_file_purpose</c>,
        /// <c>invalid_state</c>, <c>locked_by_other_job</c>, or <c>too_many_objects</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        [JsonProperty("erroring_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("erroring_object")]
#endif
        public Dictionary<string, string> ErroringObject { get; set; }

        [JsonProperty("message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("message")]
#endif
        public string Message { get; set; }
    }
}
