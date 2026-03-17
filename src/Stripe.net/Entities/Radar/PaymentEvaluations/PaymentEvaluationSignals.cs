// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationSignals : StripeEntity<PaymentEvaluationSignals>
    {
        /// <summary>
        /// A payment evaluation signal with evaluated_at, risk_level, and score fields.
        /// </summary>
        [JsonProperty("fraudulent_payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fraudulent_payment")]
#endif
        public PaymentEvaluationSignalsFraudulentPayment FraudulentPayment { get; set; }
    }
}
