// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever a Payment Link is deactivated.
    /// </summary>
    public class V1PaymentLinkDeactivatedEventNotification : V2.Core.EventNotification
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

        public V1PaymentLinkDeactivatedEvent FetchEvent()
        {
            return this.FetchEvent<V1PaymentLinkDeactivatedEvent>();
        }

        public Task<V1PaymentLinkDeactivatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1PaymentLinkDeactivatedEvent>();
        }
    }
}
