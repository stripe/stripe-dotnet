// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a QueryRun has successfully completed.
    /// </summary>
    public class V2DataQueryRunSucceededEventNotification : V2.Core.EventNotification
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
        public Task<V2.Data.QueryRun> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Data.QueryRun>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Data.QueryRun FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Data.QueryRun>(this.RelatedObject);
        }

        public V2DataQueryRunSucceededEvent FetchEvent()
        {
            return this.FetchEvent<V2DataQueryRunSucceededEvent>();
        }

        public Task<V2DataQueryRunSucceededEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2DataQueryRunSucceededEvent>();
        }
    }
}
