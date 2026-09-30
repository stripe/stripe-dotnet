// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever a customer is switched from one coupon to another.
    /// </summary>
    public class V1CustomerDiscountUpdatedEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]
        public V2.Core.EventNotificationRelatedSingletonObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Discount> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Discount>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Discount FetchRelatedObject()
        {
            return this.FetchRelatedObject<Discount>(this.RelatedObject);
        }

        public V1CustomerDiscountUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1CustomerDiscountUpdatedEvent>();
        }

        public Task<V1CustomerDiscountUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1CustomerDiscountUpdatedEvent>();
        }
    }
}
