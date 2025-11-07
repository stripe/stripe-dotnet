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
    /// OffSessionPayment. This event has been renamed this to attempt_failed, but we are
    /// keeping this around for backwards compatibility.
    /// </summary>
    public class V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent : V2.Core.Event
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventRelatedObject RelatedObject { get; set; }

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
    }
}
