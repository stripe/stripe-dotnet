// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeDelinquencyControlRiskReserve : StripeEntity<EvaluationOutcomeDelinquencyControlRiskReserve>
    {
        /// <summary>
        /// Whether to update, maintain, or clear reserves.
        /// One of: <c>clear_reserve</c>, <c>maintain_current_state</c>, or <c>update_reserve</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// Recommended reserve configuration, specifying the percentage of funds to hold, when to
        /// release them, and whether to include available funds. Populated for update_reserve; null
        /// for maintain_current_state and clear_reserve.
        /// </summary>
        [JsonProperty("target")]
        [STJS.JsonPropertyName("target")]
        public EvaluationOutcomeDelinquencyControlRiskReserveTarget Target { get; set; }
    }
}
