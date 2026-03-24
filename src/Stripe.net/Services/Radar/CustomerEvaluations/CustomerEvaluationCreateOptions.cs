// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerEvaluationCreateOptions : BaseOptions
    {
        /// <summary>
        /// Array of context entries for the evaluation.
        /// </summary>
        [JsonProperty("evaluation_context")]
        [STJS.JsonPropertyName("evaluation_context")]
        public List<CustomerEvaluationEvaluationContextOptions> EvaluationContext { get; set; }

        /// <summary>
        /// The type of evaluation event.
        /// One of: <c>login</c>, or <c>registration</c>.
        /// </summary>
        [JsonProperty("event_type")]
        [STJS.JsonPropertyName("event_type")]
        public string EventType { get; set; }
    }
}
