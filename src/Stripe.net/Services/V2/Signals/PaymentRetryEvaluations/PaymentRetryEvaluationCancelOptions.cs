// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRetryEvaluationCancelOptions : BaseOptions
    {
        /// <summary>
        /// Optional reason for canceling the evaluation.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        [STJS.JsonPropertyName("cancellation_reason")]
        public string CancellationReason { get; set; }
    }
}
