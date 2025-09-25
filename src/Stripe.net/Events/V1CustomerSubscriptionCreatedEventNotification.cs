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
    /// Occurs whenever a customer is signed up for a new plan.
    /// </summary>
    public class V1CustomerSubscriptionCreatedEventNotification : V2.EventNotification
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
        public Task<Subscription> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Subscription>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Subscription FetchRelatedObject()
        {
            return this.FetchRelatedObject<Subscription>(this.RelatedObject);
        }

        public V1CustomerSubscriptionCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1CustomerSubscriptionCreatedEvent>();
        }

        public Task<V1CustomerSubscriptionCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1CustomerSubscriptionCreatedEvent>();
        }
    }
}
