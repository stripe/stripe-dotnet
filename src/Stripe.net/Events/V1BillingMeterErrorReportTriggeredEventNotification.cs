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
    /// Occurs when a Meter has invalid async usage events.
    /// </summary>
    public class V1BillingMeterErrorReportTriggeredEventNotification : V2.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventNotificationRelatedObject RelatedObject { get; set; }

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

        public V1BillingMeterErrorReportTriggeredEvent FetchEvent()
        {
            return this.FetchEvent<V1BillingMeterErrorReportTriggeredEvent>();
        }

        public Task<V1BillingMeterErrorReportTriggeredEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1BillingMeterErrorReportTriggeredEvent>();
        }
    }
}
