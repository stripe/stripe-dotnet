// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class V1BillingMeterErrorReportTriggeredEventData : StripeEntity<V1BillingMeterErrorReportTriggeredEventData>
    {
        /// <summary>
        /// Extra field included in the event's <c>data</c> when fetched from /v2/events.
        /// </summary>
        [JsonProperty("developer_message_summary")]
        public string DeveloperMessageSummary { get; set; }

        /// <summary>
        /// This contains information about why meter error happens.
        /// </summary>
        [JsonProperty("reason")]
        public V1BillingMeterErrorReportTriggeredEventDataReason Reason { get; set; }

        /// <summary>
        /// The end of the window that is encapsulated by this summary.
        /// </summary>
        [JsonProperty("validation_end")]
        public DateTime ValidationEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The start of the window that is encapsulated by this summary.
        /// </summary>
        [JsonProperty("validation_start")]
        public DateTime ValidationStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
