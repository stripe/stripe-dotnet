// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever tax settings is updated.
    /// </summary>
    public class V1TaxSettingsUpdatedEventNotification : V2.Core.EventNotification
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
        public Task<Tax.Settings> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Tax.Settings>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Tax.Settings FetchRelatedObject()
        {
            return this.FetchRelatedObject<Tax.Settings>(this.RelatedObject);
        }

        public V1TaxSettingsUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1TaxSettingsUpdatedEvent>();
        }

        public Task<V1TaxSettingsUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1TaxSettingsUpdatedEvent>();
        }
    }
}
