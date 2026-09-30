// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationEventUserInterventionResolved : StripeEntity<PaymentEvaluationEventUserInterventionResolved>
    {
        /// <summary>
        /// Unique ID of this intervention. Use this to provide the result.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Result of the intervention if it has been completed.
        /// One of: <c>abandoned</c>, <c>failed</c>, or <c>passed</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("outcome")]
        [STJS.JsonPropertyName("outcome")]
        public string Outcome { get; set; }
    }
}
