// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationSignals : StripeEntity<PaymentEvaluationSignals>
    {
        /// <summary>
        /// A payment evaluation signal with evaluated_at, risk_level, and score fields.
        /// </summary>
        [JsonProperty("fraudulent_payment")]
        [STJS.JsonPropertyName("fraudulent_payment")]
        public PaymentEvaluationSignalsFraudulentPayment FraudulentPayment { get; set; }
    }
}
