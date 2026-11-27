// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeDelinquencyBusinessObjective : StripeEntity<EvaluationOutcomeDelinquencyBusinessObjective>
    {
        /// <summary>
        /// Expected profitability, revenue, and losses if the current reserve configuration remains
        /// unchanged. Provides a comparison for projected_outcome. Null when not reliably
        /// quantifiable.
        /// </summary>
        [JsonProperty("baseline_outcome")]
        [STJS.JsonPropertyName("baseline_outcome")]
        public EvaluationOutcomeDelinquencyBusinessObjectiveBaselineOutcome BaselineOutcome { get; set; }

        /// <summary>
        /// Expected profitability, revenue, and losses if the recommended controls are applied.
        /// Equals baseline_outcome when the recommendation maintains the current state. Null when
        /// not reliably quantifiable.
        /// </summary>
        [JsonProperty("projected_outcome")]
        [STJS.JsonPropertyName("projected_outcome")]
        public EvaluationOutcomeDelinquencyBusinessObjectiveProjectedOutcome ProjectedOutcome { get; set; }

        /// <summary>
        /// The financial objective the recommended controls are intended to improve.
        /// One of: <c>profitability</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
