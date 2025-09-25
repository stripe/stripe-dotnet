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
    /// Occurs whenever a new invoice is created. To learn how webhooks can be used with this
    /// event, and how they can affect it, see <a
    /// href="https://docs.stripe.com/subscriptions/webhooks">Using Webhooks with
    /// Subscriptions</a>.
    /// </summary>
    public class V1InvoiceCreatedEventNotification : V2.EventNotification
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

        public V1InvoiceCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1InvoiceCreatedEvent>();
        }

        public Task<V1InvoiceCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1InvoiceCreatedEvent>();
        }
    }
}
