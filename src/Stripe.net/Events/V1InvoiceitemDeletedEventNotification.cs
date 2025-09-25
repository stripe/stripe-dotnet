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
    /// Occurs whenever an invoice item is deleted.
    /// </summary>
    public class V1InvoiceitemDeletedEventNotification : V2.EventNotification
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

        public V1InvoiceitemDeletedEvent FetchEvent()
        {
            return this.FetchEvent<V1InvoiceitemDeletedEvent>();
        }

        public Task<V1InvoiceitemDeletedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1InvoiceitemDeletedEvent>();
        }
    }
}
