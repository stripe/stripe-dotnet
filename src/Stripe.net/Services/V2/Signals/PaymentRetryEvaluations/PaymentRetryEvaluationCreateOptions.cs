// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRetryEvaluationCreateOptions : BaseOptions
    {
        /// <summary>
        /// ID of the PaymentIntent to evaluate. Mutually exclusive with payment_record.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// ID of the PaymentRecord to evaluate. Mutually exclusive with payment_intent.
        /// </summary>
        [JsonProperty("payment_record")]
        [STJS.JsonPropertyName("payment_record")]
        public string PaymentRecord { get; set; }
    }
}
