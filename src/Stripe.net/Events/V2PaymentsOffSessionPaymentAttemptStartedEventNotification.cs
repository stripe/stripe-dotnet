// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Sent when our internal scheduling system kicks off an attempt, whether it's a retry or
    /// an initial attempt.
    /// </summary>
    public class V2PaymentsOffSessionPaymentAttemptStartedEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

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

        public V2PaymentsOffSessionPaymentAttemptStartedEvent FetchEvent()
        {
            return this.FetchEvent<V2PaymentsOffSessionPaymentAttemptStartedEvent>();
        }

        public Task<V2PaymentsOffSessionPaymentAttemptStartedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2PaymentsOffSessionPaymentAttemptStartedEvent>();
        }
    }
}
