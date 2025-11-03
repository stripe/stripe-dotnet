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
    /// Occurs when a ReportRun has successfully completed.
    /// </summary>
    public class V2ReportingReportRunSucceededEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<V2.Reporting.ReportRun> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Reporting.ReportRun>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Reporting.ReportRun FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Reporting.ReportRun>(this.RelatedObject);
        }

        public V2ReportingReportRunSucceededEvent FetchEvent()
        {
            return this.FetchEvent<V2ReportingReportRunSucceededEvent>();
        }

        public Task<V2ReportingReportRunSucceededEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2ReportingReportRunSucceededEvent>();
        }
    }
}
