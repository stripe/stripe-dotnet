// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerEvaluationCreateOptions : BaseOptions
    {
        /// <summary>
        /// Array of context entries for the evaluation.
        /// </summary>
        [JsonProperty("evaluation_context")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("evaluation_context")]
#endif
        public List<CustomerEvaluationEvaluationContextOptions> EvaluationContext { get; set; }

        /// <summary>
        /// The type of evaluation event.
        /// One of: <c>login</c>, or <c>registration</c>.
        /// </summary>
        [JsonProperty("event_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_type")]
#endif
        public string EventType { get; set; }
    }
}
