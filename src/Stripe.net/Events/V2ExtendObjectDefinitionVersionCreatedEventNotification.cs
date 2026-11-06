// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an object definition version is created.
    /// </summary>
    public class V2ExtendObjectDefinitionVersionCreatedEventNotification : V2.Core.EventNotification
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
        public Task<V2.Extend.ObjectDefinitionVersion> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Extend.ObjectDefinitionVersion>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Extend.ObjectDefinitionVersion FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Extend.ObjectDefinitionVersion>(this.RelatedObject);
        }

        public V2ExtendObjectDefinitionVersionCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V2ExtendObjectDefinitionVersionCreatedEvent>();
        }

        public Task<V2ExtendObjectDefinitionVersionCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2ExtendObjectDefinitionVersionCreatedEvent>();
        }
    }
}
