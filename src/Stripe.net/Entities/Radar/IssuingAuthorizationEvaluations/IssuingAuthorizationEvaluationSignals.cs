// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuingAuthorizationEvaluationSignals : StripeEntity<IssuingAuthorizationEvaluationSignals>
    {
        /// <summary>
        /// A fraud risk signal with status, error, and data fields.
        /// </summary>
        [JsonProperty("fraud_risk")]
        [STJS.JsonPropertyName("fraud_risk")]
        public IssuingAuthorizationEvaluationSignalsFraudRisk FraudRisk { get; set; }
    }
}
