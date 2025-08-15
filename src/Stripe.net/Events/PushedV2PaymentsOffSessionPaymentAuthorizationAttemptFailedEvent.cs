// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Sent after a failed authorization if there are still retries available on the
    /// OffSessionPayment.
    /// </summary>
    public class PushedV2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent : V2.PushedEvent
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<V2.Payments.OffSessionPayment> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Payments.OffSessionPayment>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Payments.OffSessionPayment FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Payments.OffSessionPayment>(this.RelatedObject);
        }

        public V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent Pull()
        {
            return this.PullEvent<V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent>();
        }

        public Task<V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent> PullAsync()
        {
            return this.PullEventAsync<V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent>();
        }
    }
}
