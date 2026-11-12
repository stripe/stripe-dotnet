// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever a user updates a Stripe app. Sent to the app developer, embedding
    /// platform, and installing merchant.
    /// </summary>
    public class V1AppsInstallUpdatedEventNotification : V2.Core.EventNotification
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
        public Task<Apps.Install> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Apps.Install>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Apps.Install FetchRelatedObject()
        {
            return this.FetchRelatedObject<Apps.Install>(this.RelatedObject);
        }

        public V1AppsInstallUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1AppsInstallUpdatedEvent>();
        }

        public Task<V1AppsInstallUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1AppsInstallUpdatedEvent>();
        }
    }
}
