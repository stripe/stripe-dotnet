// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever a product is activated.
    /// </summary>
    public class V1ProductActivatedEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]
        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Product> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Product>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Product FetchRelatedObject()
        {
            return this.FetchRelatedObject<Product>(this.RelatedObject);
        }

        public V1ProductActivatedEvent FetchEvent()
        {
            return this.FetchEvent<V1ProductActivatedEvent>();
        }

        public Task<V1ProductActivatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1ProductActivatedEvent>();
        }
    }
}
