// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class EvaluationOutcomeListOptions : V2.ListOptions
    {
        /// <summary>
        /// Account selector for the historical outcomes requested.
        /// </summary>
        [JsonProperty("account_details")]
        [STJS.JsonPropertyName("account_details")]
        public EvaluationOutcomeListAccountDetailsOptions AccountDetails { get; set; }

        /// <summary>
        /// Evaluation origin to filter by. Omit to match all origins.
        /// One of: <c>rule_outcome</c>, or <c>stripe_recommendation</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("origin")]
        [STJS.JsonPropertyName("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Evaluation type to filter by. Omit to match all types.
        /// One of: <c>delinquency</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
