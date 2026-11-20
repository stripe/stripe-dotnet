// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeDelinquencyControlRiskReserveTarget : StripeEntity<EvaluationOutcomeDelinquencyControlRiskReserveTarget>
    {
        /// <summary>
        /// Integer percentage of funds to reserve.
        /// </summary>
        [JsonProperty("percent")]
        [STJS.JsonPropertyName("percent")]
        public long Percent { get; set; }

        /// <summary>
        /// Integer number of days after which reserved funds are released.
        /// </summary>
        [JsonProperty("release_after_days")]
        [STJS.JsonPropertyName("release_after_days")]
        public long ReleaseAfterDays { get; set; }

        /// <summary>
        /// How reserved funds are released.
        /// One of: <c>rolling</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("release_type")]
        [STJS.JsonPropertyName("release_type")]
        public string ReleaseType { get; set; }

        /// <summary>
        /// Whether to reserve already available funds as well as future funds.
        /// </summary>
        [JsonProperty("sweep_available_funds")]
        [STJS.JsonPropertyName("sweep_available_funds")]
        public bool SweepAvailableFunds { get; set; }
    }
}
