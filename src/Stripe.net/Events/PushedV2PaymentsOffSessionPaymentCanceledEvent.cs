// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Sent immediately following a user's call to the Off-Session Payments cancel endpoint.
    /// </summary>
    public class PushedV2PaymentsOffSessionPaymentCanceledEvent : V2.PushedEvent
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

        public V2PaymentsOffSessionPaymentCanceledEvent Pull()
        {
            return this.PullEvent<V2PaymentsOffSessionPaymentCanceledEvent>();
        }

        public Task<V2PaymentsOffSessionPaymentCanceledEvent> PullAsync()
        {
            return this.PullEventAsync<V2PaymentsOffSessionPaymentCanceledEvent>();
        }
    }
}
