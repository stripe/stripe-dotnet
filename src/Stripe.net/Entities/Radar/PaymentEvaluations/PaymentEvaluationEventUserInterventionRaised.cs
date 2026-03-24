// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationEventUserInterventionRaised : StripeEntity<PaymentEvaluationEventUserInterventionRaised>
    {
        /// <summary>
        /// User intervention raised custom event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public PaymentEvaluationEventUserInterventionRaisedCustom Custom { get; set; }

        /// <summary>
        /// Unique identifier for the user intervention event.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Type of user intervention raised.
        /// One of: <c>3ds</c>, <c>captcha</c>, or <c>custom</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
