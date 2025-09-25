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
    /// Occurs whenever a new payment method is attached to a customer.
    /// </summary>
    public class V1PaymentMethodAttachedEventNotification : V2.EventNotification
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
        public Task<PaymentMethod> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<PaymentMethod>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public PaymentMethod FetchRelatedObject()
        {
            return this.FetchRelatedObject<PaymentMethod>(this.RelatedObject);
        }

        public V1PaymentMethodAttachedEvent FetchEvent()
        {
            return this.FetchEvent<V1PaymentMethodAttachedEvent>();
        }

        public Task<V1PaymentMethodAttachedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1PaymentMethodAttachedEvent>();
        }
    }
}
