// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationOutcome : StripeEntity<PaymentEvaluationOutcome>
    {
        /// <summary>
        /// Details of a merchant_blocked outcome attached to this payment evaluation.
        /// </summary>
        [JsonProperty("merchant_blocked")]
        [STJS.JsonPropertyName("merchant_blocked")]
        public PaymentEvaluationOutcomeMerchantBlocked MerchantBlocked { get; set; }

        /// <summary>
        /// The PaymentIntent ID associated with the payment evaluation.
        /// </summary>
        [JsonProperty("payment_intent_id")]
        [STJS.JsonPropertyName("payment_intent_id")]
        public string PaymentIntentId { get; set; }

        /// <summary>
        /// Details of an rejected outcome attached to this payment evaluation.
        /// </summary>
        [JsonProperty("rejected")]
        [STJS.JsonPropertyName("rejected")]
        public PaymentEvaluationOutcomeRejected Rejected { get; set; }

        /// <summary>
        /// Details of a succeeded outcome attached to this payment evaluation.
        /// </summary>
        [JsonProperty("succeeded")]
        [STJS.JsonPropertyName("succeeded")]
        public PaymentEvaluationOutcomeSucceeded Succeeded { get; set; }

        /// <summary>
        /// Indicates the outcome of the payment evaluation.
        /// One of: <c>failed</c>, <c>merchant_blocked</c>, <c>rejected</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
