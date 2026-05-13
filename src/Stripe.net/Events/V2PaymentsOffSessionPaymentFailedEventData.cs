// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2PaymentsOffSessionPaymentFailedEventData : StripeEntity<V2PaymentsOffSessionPaymentFailedEventData>
    {
        /// <summary>
        /// The ID of the payment attempt record associated with this terminal failure. Equal to the
        /// <c>latest_payment_attempt_record</c> on the Off-Session Payment object.
        /// </summary>
        [JsonProperty("payment_attempt_record")]
        [STJS.JsonPropertyName("payment_attempt_record")]
        public string PaymentAttemptRecord { get; set; }
    }
}
