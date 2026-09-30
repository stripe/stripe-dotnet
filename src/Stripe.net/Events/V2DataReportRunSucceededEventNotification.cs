// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a ReportRun has successfully completed.
    /// </summary>
    public class V2DataReportRunSucceededEventNotification : V2.Core.EventNotification
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
        public Task<V2.Data.ReportRun> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Data.ReportRun>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Data.ReportRun FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Data.ReportRun>(this.RelatedObject);
        }

        public V2DataReportRunSucceededEvent FetchEvent()
        {
            return this.FetchEvent<V2DataReportRunSucceededEvent>();
        }

        public Task<V2DataReportRunSucceededEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2DataReportRunSucceededEvent>();
        }
    }
}
