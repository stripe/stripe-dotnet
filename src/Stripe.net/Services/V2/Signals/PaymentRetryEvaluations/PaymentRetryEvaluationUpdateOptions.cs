// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRetryEvaluationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// PaymentIntent to update to. Must match the evaluation's signal type.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// PaymentRecord to update to. Must match the evaluation's signal type.
        /// </summary>
        [JsonProperty("payment_record")]
        [STJS.JsonPropertyName("payment_record")]
        public string PaymentRecord { get; set; }
    }
}
