// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeDelinquencySupportingSignals : StripeEntity<EvaluationOutcomeDelinquencySupportingSignals>
    {
        /// <summary>
        /// The account's assessed probability and level of delinquency risk. Null when unavailable.
        /// </summary>
        [JsonProperty("merchant_delinquency")]
        [STJS.JsonPropertyName("merchant_delinquency")]
        public EvaluationOutcomeDelinquencySupportingSignalsMerchantDelinquency MerchantDelinquency { get; set; }

        /// <summary>
        /// The account's assessed financial exposure if it becomes delinquent. Null when
        /// unavailable.
        /// </summary>
        [JsonProperty("payment_delinquency_exposure")]
        [STJS.JsonPropertyName("payment_delinquency_exposure")]
        public EvaluationOutcomeDelinquencySupportingSignalsPaymentDelinquencyExposure PaymentDelinquencyExposure { get; set; }
    }
}
