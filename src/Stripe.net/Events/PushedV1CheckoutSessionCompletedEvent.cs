// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a Checkout Session has been successfully completed.
    /// </summary>
    public class PushedV1CheckoutSessionCompletedEvent : V2.PushedEvent
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

        public V1CheckoutSessionCompletedEvent Pull()
        {
            return this.PullEvent<V1CheckoutSessionCompletedEvent>();
        }

        public Task<V1CheckoutSessionCompletedEvent> PullAsync()
        {
            return this.PullEventAsync<V1CheckoutSessionCompletedEvent>();
        }
    }
}
