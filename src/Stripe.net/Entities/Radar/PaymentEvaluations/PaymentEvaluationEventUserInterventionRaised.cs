// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationEventUserInterventionRaised : StripeEntity<PaymentEvaluationEventUserInterventionRaised>
    {
        /// <summary>
        /// User intervention raised custom event details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("custom")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom")]
#endif
        public PaymentEvaluationEventUserInterventionRaisedCustom Custom { get; set; }

        /// <summary>
        /// Unique identifier for the user intervention event.
        /// </summary>
        [JsonProperty("key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("key")]
#endif
        public string Key { get; set; }

        /// <summary>
        /// Type of user intervention raised.
        /// One of: <c>3ds</c>, <c>captcha</c>, or <c>custom</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
