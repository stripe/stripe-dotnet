// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever a draft invoice cannot be finalized. See the invoice’s <a
    /// href="https://docs.stripe.com/api/invoices/object#invoice_object-last_finalization_error">last
    /// finalization error</a> for details.
    /// </summary>
    public class V1InvoiceFinalizationFailedEventNotification : V2.Core.EventNotification
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
        public Task<Invoice> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Invoice>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Invoice FetchRelatedObject()
        {
            return this.FetchRelatedObject<Invoice>(this.RelatedObject);
        }

        public V1InvoiceFinalizationFailedEvent FetchEvent()
        {
            return this.FetchEvent<V1InvoiceFinalizationFailedEvent>();
        }

        public Task<V1InvoiceFinalizationFailedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1InvoiceFinalizationFailedEvent>();
        }
    }
}
