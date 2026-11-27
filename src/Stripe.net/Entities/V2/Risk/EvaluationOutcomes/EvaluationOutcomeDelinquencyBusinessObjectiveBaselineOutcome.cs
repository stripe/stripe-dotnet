// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeDelinquencyBusinessObjectiveBaselineOutcome : StripeEntity<EvaluationOutcomeDelinquencyBusinessObjectiveBaselineOutcome>
    {
        /// <summary>
        /// Expected financial loss from delinquency under this reserve configuration, expressed as
        /// a negative amount.
        /// </summary>
        [JsonProperty("loss")]
        [STJS.JsonPropertyName("loss")]
        public V2.Amount Loss { get; set; }

        /// <summary>
        /// Expected financial result after accounting for revenue and losses. Can be negative.
        /// </summary>
        [JsonProperty("profitability")]
        [STJS.JsonPropertyName("profitability")]
        public V2.Amount Profitability { get; set; }

        /// <summary>
        /// Expected revenue under this reserve configuration.
        /// </summary>
        [JsonProperty("revenue")]
        [STJS.JsonPropertyName("revenue")]
        public V2.Amount Revenue { get; set; }
    }
}
