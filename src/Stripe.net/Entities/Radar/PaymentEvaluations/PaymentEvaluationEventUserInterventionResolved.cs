// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationEventUserInterventionResolved : StripeEntity<PaymentEvaluationEventUserInterventionResolved>
    {
        /// <summary>
        /// Unique ID of this intervention. Use this to provide the result.
        /// </summary>
        [JsonProperty("key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("key")]
#endif
        public string Key { get; set; }

        /// <summary>
        /// Result of the intervention if it has been completed.
        /// One of: <c>abandoned</c>, <c>failed</c>, or <c>passed</c>.
        /// </summary>
        [JsonProperty("outcome")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outcome")]
#endif
        public string Outcome { get; set; }
    }
}
