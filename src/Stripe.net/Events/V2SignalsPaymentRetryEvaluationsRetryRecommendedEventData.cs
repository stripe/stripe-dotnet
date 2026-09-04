// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2SignalsPaymentRetryEvaluationsRetryRecommendedEventData : StripeEntity<V2SignalsPaymentRetryEvaluationsRetryRecommendedEventData>,
        IHasId
    {
        /// <summary>
        /// Unique identifier for the payment retry evaluation.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Whether the event was created in livemode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The PaymentIntent ID. Present when the evaluation is for a PaymentIntent.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// The PaymentRecord ID. Present when the evaluation is for a PaymentRecord.
        /// </summary>
        [JsonProperty("payment_record")]
        [STJS.JsonPropertyName("payment_record")]
        public string PaymentRecord { get; set; }
    }
}
