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
    /// Occurs when an InvoicePayment is successfully paid.
    /// </summary>
    public class V1InvoicePaymentPaidEventNotification : V2.EventNotification
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

        public V1InvoicePaymentPaidEvent FetchEvent()
        {
            return this.FetchEvent<V1InvoicePaymentPaidEvent>();
        }

        public Task<V1InvoicePaymentPaidEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1InvoicePaymentPaidEvent>();
        }
    }
}
