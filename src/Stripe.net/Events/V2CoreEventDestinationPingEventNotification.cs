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
    /// A ping event used to test the connection to an EventDestination.
    /// </summary>
    public class V2CoreEventDestinationPingEventNotification : V2.Core.EventNotification
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
        public Task<V2.Core.EventDestination> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Core.EventDestination>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Core.EventDestination FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Core.EventDestination>(this.RelatedObject);
        }

        public V2CoreEventDestinationPingEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreEventDestinationPingEvent>();
        }

        public Task<V2CoreEventDestinationPingEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreEventDestinationPingEvent>();
        }
    }
}
