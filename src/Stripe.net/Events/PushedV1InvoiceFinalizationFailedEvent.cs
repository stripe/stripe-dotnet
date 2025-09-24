// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a draft invoice cannot be finalized. See the invoice’s <a
    /// href="https://docs.stripe.com/api/invoices/object#invoice_object-last_finalization_error">last
    /// finalization error</a> for details.
    /// </summary>
    public class PushedV1InvoiceFinalizationFailedEvent : V2.PushedEvent
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

        public V1InvoiceFinalizationFailedEvent Pull()
        {
            return this.PullEvent<V1InvoiceFinalizationFailedEvent>();
        }

        public Task<V1InvoiceFinalizationFailedEvent> PullAsync()
        {
            return this.PullEventAsync<V1InvoiceFinalizationFailedEvent>();
        }
    }
}
