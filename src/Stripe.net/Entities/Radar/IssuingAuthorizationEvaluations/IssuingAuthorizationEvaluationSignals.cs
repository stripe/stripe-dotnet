// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationSignals : StripeEntity<IssuingAuthorizationEvaluationSignals>
    {
        /// <summary>
        /// A fraud risk signal with status, error, and data fields.
        /// </summary>
        [JsonProperty("fraud_risk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fraud_risk")]
#endif
        public IssuingAuthorizationEvaluationSignalsFraudRisk FraudRisk { get; set; }
    }
}
