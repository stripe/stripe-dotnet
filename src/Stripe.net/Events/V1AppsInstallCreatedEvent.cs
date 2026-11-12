// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever a user installs a Stripe app. Sent to the app developer, embedding
    /// platform, and installing merchant.
    /// </summary>
    public class V1AppsInstallCreatedEvent : V2.Core.Event
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]
        public V2.Core.EventRelatedObject RelatedObject { get; set; }

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
    }
}
