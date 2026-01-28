// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationOutcomeSucceeded : StripeEntity<PaymentEvaluationOutcomeSucceeded>
    {
        /// <summary>
        /// Details of an succeeded card outcome attached to this payment evaluation.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public PaymentEvaluationOutcomeSucceededCard Card { get; set; }
    }
}
