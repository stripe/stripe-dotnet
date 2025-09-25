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
    /// Occurs X number of days before a subscription is scheduled to create an invoice that is
    /// automatically charged—where X is determined by your <a
    /// href="https://dashboard.stripe.com/account/billing/automatic">subscriptions
    /// settings</a>. Note: The received <c>Invoice</c> object will not have an invoice ID.
    /// </summary>
    public class V1InvoiceUpcomingEventNotification : V2.EventNotification
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

        public V1InvoiceUpcomingEvent FetchEvent()
        {
            return this.FetchEvent<V1InvoiceUpcomingEvent>();
        }

        public Task<V1InvoiceUpcomingEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1InvoiceUpcomingEvent>();
        }
    }
}
