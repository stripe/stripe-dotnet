// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// This event occurs when there are invalid async usage events for a given meter.
    /// </summary>
    public class V1BillingMeterErrorReportTriggeredEvent : V2.Event
    {
        /// <summary>
        /// Data for the v1.billing.meter.error_report_triggered event.
        /// </summary>
        [JsonProperty("data")]

        public V1BillingMeterErrorReportTriggeredEventData Data { get; set; }

        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]

        public V2.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Billing.Meter> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Billing.Meter>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Billing.Meter FetchRelatedObject()
        {
            return this.FetchRelatedObject<Billing.Meter>(this.RelatedObject);
        }
    }
}
