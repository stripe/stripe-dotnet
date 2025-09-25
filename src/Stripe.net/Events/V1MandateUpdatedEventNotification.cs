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
    /// Occurs whenever a Mandate is updated.
    /// </summary>
    public class V1MandateUpdatedEventNotification : V2.EventNotification
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
        public Task<Mandate> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Mandate>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Mandate FetchRelatedObject()
        {
            return this.FetchRelatedObject<Mandate>(this.RelatedObject);
        }

        public V1MandateUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1MandateUpdatedEvent>();
        }

        public Task<V1MandateUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1MandateUpdatedEvent>();
        }
    }
}
