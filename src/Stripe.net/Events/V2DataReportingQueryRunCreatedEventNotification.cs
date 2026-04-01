// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a QueryRun is created.
    /// </summary>
    public class V2DataReportingQueryRunCreatedEventNotification : V2.Core.EventNotification
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
        public Task<V2.Data.Reporting.QueryRun> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Data.Reporting.QueryRun>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Data.Reporting.QueryRun FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Data.Reporting.QueryRun>(this.RelatedObject);
        }

        public V2DataReportingQueryRunCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V2DataReportingQueryRunCreatedEvent>();
        }

        public Task<V2DataReportingQueryRunCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2DataReportingQueryRunCreatedEvent>();
        }
    }
}
