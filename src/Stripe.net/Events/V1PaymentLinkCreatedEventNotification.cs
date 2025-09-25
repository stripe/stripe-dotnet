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
    /// Occurs when a payment link is created.
    /// </summary>
    public class V1PaymentLinkCreatedEventNotification : V2.EventNotification
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
        public Task<PaymentLink> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<PaymentLink>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public PaymentLink FetchRelatedObject()
        {
            return this.FetchRelatedObject<PaymentLink>(this.RelatedObject);
        }

        public V1PaymentLinkCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1PaymentLinkCreatedEvent>();
        }

        public Task<V1PaymentLinkCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1PaymentLinkCreatedEvent>();
        }
    }
}
