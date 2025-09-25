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
    /// Occurs whenever a review is closed. The review's <c>reason</c> field indicates why:
    /// <c>approved</c>, <c>disputed</c>, <c>refunded</c>, <c>refunded_as_fraud</c>, or
    /// <c>canceled</c>.
    /// </summary>
    public class V1ReviewClosedEventNotification : V2.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Review> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Review>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Review FetchRelatedObject()
        {
            return this.FetchRelatedObject<Review>(this.RelatedObject);
        }

        public V1ReviewClosedEvent FetchEvent()
        {
            return this.FetchEvent<V1ReviewClosedEvent>();
        }

        public Task<V1ReviewClosedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1ReviewClosedEvent>();
        }
    }
}
