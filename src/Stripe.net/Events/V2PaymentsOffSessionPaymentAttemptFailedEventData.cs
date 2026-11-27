// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2PaymentsOffSessionPaymentAttemptFailedEventData : StripeEntity<V2PaymentsOffSessionPaymentAttemptFailedEventData>
    {
        /// <summary>
        /// The ID of the payment attempt record associated with this failed attempt.
        /// </summary>
        [JsonProperty("payment_attempt_record")]
        [STJS.JsonPropertyName("payment_attempt_record")]
        public string PaymentAttemptRecord { get; set; }
    }
}
