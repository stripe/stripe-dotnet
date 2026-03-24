// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationOutcomeSucceeded : StripeEntity<PaymentEvaluationOutcomeSucceeded>
    {
        /// <summary>
        /// Details of an succeeded card outcome attached to this payment evaluation.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentEvaluationOutcomeSucceededCard Card { get; set; }
    }
}
