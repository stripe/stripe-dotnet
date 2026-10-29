// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever an invoice payment record is created in open status.
    /// </summary>
    public class V1InvoicePaymentOpenEventNotification : V2.Core.EventNotification
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
        public Task<InvoicePayment> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<InvoicePayment>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public InvoicePayment FetchRelatedObject()
        {
            return this.FetchRelatedObject<InvoicePayment>(this.RelatedObject);
        }

        public V1InvoicePaymentOpenEvent FetchEvent()
        {
            return this.FetchEvent<V1InvoicePaymentOpenEvent>();
        }

        public Task<V1InvoicePaymentOpenEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1InvoicePaymentOpenEvent>();
        }
    }
}
