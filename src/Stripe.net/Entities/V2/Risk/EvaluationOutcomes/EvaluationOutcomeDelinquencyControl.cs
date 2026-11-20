// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeDelinquencyControl : StripeEntity<EvaluationOutcomeDelinquencyControl>
    {
        /// <summary>
        /// The recommended action for funds held in reserve, including a target configuration when
        /// updating reserves. Populated when type is risk_reserve; null otherwise.
        /// </summary>
        [JsonProperty("risk_reserve")]
        [STJS.JsonPropertyName("risk_reserve")]
        public EvaluationOutcomeDelinquencyControlRiskReserve RiskReserve { get; set; }

        /// <summary>
        /// The kind of control recommended to manage risk.
        /// One of: <c>risk_reserve</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
