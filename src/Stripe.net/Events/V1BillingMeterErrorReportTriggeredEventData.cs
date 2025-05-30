// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V1BillingMeterErrorReportTriggeredEventData : StripeEntity<V1BillingMeterErrorReportTriggeredEventData>
    {
        /// <summary>
        /// This contains information about why meter error happens.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public V1BillingMeterErrorReportTriggeredEventDataReason Reason { get; set; }

        /// <summary>
        /// Extra field included in the event's <c>data</c> when fetched from /v2/events.
        /// </summary>
        [JsonProperty("developer_message_summary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("developer_message_summary")]
#endif
        public string DeveloperMessageSummary { get; set; }

        /// <summary>
        /// The start of the window that is encapsulated by this summary.
        /// </summary>
        [JsonProperty("validation_start")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validation_start")]
#endif
        public DateTime ValidationStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The end of the window that is encapsulated by this summary.
        /// </summary>
        [JsonProperty("validation_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validation_end")]
#endif
        public DateTime ValidationEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
