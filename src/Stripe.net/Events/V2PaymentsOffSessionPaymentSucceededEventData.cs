// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2PaymentsOffSessionPaymentSucceededEventData : StripeEntity<V2PaymentsOffSessionPaymentSucceededEventData>
    {
        /// <summary>
        /// The ID of the payment attempt record associated with this successful attempt.
        /// </summary>
        [JsonProperty("payment_attempt_record")]
        [STJS.JsonPropertyName("payment_attempt_record")]
        public string PaymentAttemptRecord { get; set; }
    }
}
