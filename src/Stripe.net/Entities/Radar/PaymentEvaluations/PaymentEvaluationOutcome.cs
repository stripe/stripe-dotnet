// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationOutcome : StripeEntity<PaymentEvaluationOutcome>
    {
        /// <summary>
        /// Details of a merchant_blocked outcome attached to this payment evaluation.
        /// </summary>
        [JsonProperty("merchant_blocked")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_blocked")]
#endif
        public PaymentEvaluationOutcomeMerchantBlocked MerchantBlocked { get; set; }

        /// <summary>
        /// The PaymentIntent ID associated with the payment evaluation.
        /// </summary>
        [JsonProperty("payment_intent_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent_id")]
#endif
        public string PaymentIntentId { get; set; }

        /// <summary>
        /// Details of an rejected outcome attached to this payment evaluation.
        /// </summary>
        [JsonProperty("rejected")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rejected")]
#endif
        public PaymentEvaluationOutcomeRejected Rejected { get; set; }

        /// <summary>
        /// Details of a succeeded outcome attached to this payment evaluation.
        /// </summary>
        [JsonProperty("succeeded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("succeeded")]
#endif
        public PaymentEvaluationOutcomeSucceeded Succeeded { get; set; }

        /// <summary>
        /// Indicates the outcome of the payment evaluation.
        /// One of: <c>failed</c>, <c>merchant_blocked</c>, <c>rejected</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
