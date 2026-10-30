// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a discount is added to an invoice item.
    /// </summary>
    public class V1InvoiceitemDiscountAddedEventNotification : V2.Core.EventNotification
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
        public Task<InvoiceItem> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<InvoiceItem>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public InvoiceItem FetchRelatedObject()
        {
            return this.FetchRelatedObject<InvoiceItem>(this.RelatedObject);
        }

        public V1InvoiceitemDiscountAddedEvent FetchEvent()
        {
            return this.FetchEvent<V1InvoiceitemDiscountAddedEvent>();
        }

        public Task<V1InvoiceitemDiscountAddedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1InvoiceitemDiscountAddedEvent>();
        }
    }
}
