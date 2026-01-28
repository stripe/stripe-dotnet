// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationEventEarlyFraudWarningReceived : StripeEntity<PaymentEvaluationEventEarlyFraudWarningReceived>
    {
        /// <summary>
        /// The type of fraud labeled by the issuer.
        /// One of: <c>made_with_lost_card</c>, <c>made_with_stolen_card</c>, <c>other</c>, or
        /// <c>unauthorized_use_of_card</c>.
        /// </summary>
        [JsonProperty("fraud_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fraud_type")]
#endif
        public string FraudType { get; set; }
    }
}
