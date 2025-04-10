// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RedactionJobCreateOptions : BaseOptions
    {
        /// <summary>
        /// The objects at the root level that are subject to redaction.
        /// </summary>
        [JsonProperty("objects")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("objects")]
#endif
        public RedactionJobObjectsOptions Objects { get; set; }

        /// <summary>
        /// Default is "error". If "error", we will make sure all objects in the graph are
        /// redactable in the 1st traversal, otherwise error. If "fix", where possible, we will
        /// auto-fix any validation errors (e.g. by auto-transitioning objects to a terminal state,
        /// etc.) in the 2nd traversal before redacting.
        /// One of: <c>error</c>, or <c>fix</c>.
        /// </summary>
        [JsonProperty("validation_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validation_behavior")]
#endif
        public string ValidationBehavior { get; set; }
    }
}
