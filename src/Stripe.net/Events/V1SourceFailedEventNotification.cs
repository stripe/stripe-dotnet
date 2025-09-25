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
    /// Occurs whenever a source fails.
    /// </summary>
    public class V1SourceFailedEventNotification : V2.EventNotification
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
        public Task<Source> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Source>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Source FetchRelatedObject()
        {
            return this.FetchRelatedObject<Source>(this.RelatedObject);
        }

        public V1SourceFailedEvent FetchEvent()
        {
            return this.FetchEvent<V1SourceFailedEvent>();
        }

        public Task<V1SourceFailedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1SourceFailedEvent>();
        }
    }
}
