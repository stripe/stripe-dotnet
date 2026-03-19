// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when merchant fails to upload a file in time.
    /// </summary>
    public class V2CoreBatchJobUploadTimeoutEventNotification : V2.Core.EventNotification
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
        public Task<V2.Core.BatchJob> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Core.BatchJob>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Core.BatchJob FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Core.BatchJob>(this.RelatedObject);
        }

        public V2CoreBatchJobUploadTimeoutEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreBatchJobUploadTimeoutEvent>();
        }

        public Task<V2CoreBatchJobUploadTimeoutEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreBatchJobUploadTimeoutEvent>();
        }
    }
}
