// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeAccountDetails : StripeEntity<EvaluationOutcomeAccountDetails>
    {
        /// <summary>
        /// Connected account evaluated.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Customer evaluated.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Inline subject data for an evaluation without a Stripe entity.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public EvaluationOutcomeAccountDetailsData Data { get; set; }
    }
}
