// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationEventEarlyFraudWarningReceived : StripeEntity<PaymentEvaluationEventEarlyFraudWarningReceived>
    {
        /// <summary>
        /// The type of fraud labeled by the issuer.
        /// One of: <c>made_with_lost_card</c>, <c>made_with_stolen_card</c>, <c>other</c>, or
        /// <c>unauthorized_use_of_card</c>.
        /// </summary>
        [JsonProperty("fraud_type")]
        [STJS.JsonPropertyName("fraud_type")]
        public string FraudType { get; set; }
    }
}
