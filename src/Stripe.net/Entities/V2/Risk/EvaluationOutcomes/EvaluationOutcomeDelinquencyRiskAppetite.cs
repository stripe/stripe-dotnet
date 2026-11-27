// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeDelinquencyRiskAppetite : StripeEntity<EvaluationOutcomeDelinquencyRiskAppetite>
    {
        /// <summary>
        /// How the recommendation prioritizes protection from losses relative to revenue.
        /// One of: <c>balanced</c>, <c>maximize_protection</c>, or <c>maximize_revenue</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }
    }
}
