// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an object definition is created.
    /// </summary>
    public class V2ExtendObjectDefinitionCreatedEventNotification : V2.Core.EventNotification
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
        public Task<V2.Extend.ObjectDefinition> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Extend.ObjectDefinition>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Extend.ObjectDefinition FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Extend.ObjectDefinition>(this.RelatedObject);
        }

        public V2ExtendObjectDefinitionCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V2ExtendObjectDefinitionCreatedEvent>();
        }

        public Task<V2ExtendObjectDefinitionCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2ExtendObjectDefinitionCreatedEvent>();
        }
    }
}
