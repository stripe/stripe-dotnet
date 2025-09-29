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
    /// Occurs when a payment intent using a delayed payment method finally succeeds.
    /// </summary>
    public class V1CheckoutSessionAsyncPaymentSucceededEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Checkout.Session> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Checkout.Session>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Checkout.Session FetchRelatedObject()
        {
            return this.FetchRelatedObject<Checkout.Session>(this.RelatedObject);
        }

        public V1CheckoutSessionAsyncPaymentSucceededEvent FetchEvent()
        {
            return this.FetchEvent<V1CheckoutSessionAsyncPaymentSucceededEvent>();
        }

        public Task<V1CheckoutSessionAsyncPaymentSucceededEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1CheckoutSessionAsyncPaymentSucceededEvent>();
        }
    }
}
