// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a product catalog import file has been uploaded and has started processing.
    /// </summary>
    public class V2CommerceProductCatalogImportsProcessingEventNotification : V2.Core.EventNotification
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
        public Task<V2.Commerce.ProductCatalogImport> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Commerce.ProductCatalogImport>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Commerce.ProductCatalogImport FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Commerce.ProductCatalogImport>(this.RelatedObject);
        }

        public V2CommerceProductCatalogImportsProcessingEvent FetchEvent()
        {
            return this.FetchEvent<V2CommerceProductCatalogImportsProcessingEvent>();
        }

        public Task<V2CommerceProductCatalogImportsProcessingEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CommerceProductCatalogImportsProcessingEvent>();
        }
    }
}
