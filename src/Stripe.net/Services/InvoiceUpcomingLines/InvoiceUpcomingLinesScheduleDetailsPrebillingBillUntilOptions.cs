// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceUpcomingLinesScheduleDetailsPrebillingBillUntilOptions : INestedOptions
    {
        /// <summary>
        /// End the prebilled period when a specified amendment ends.
        /// </summary>
        [JsonProperty("amendment_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amendment_end")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsPrebillingBillUntilAmendmentEndOptions AmendmentEnd { get; set; }

        /// <summary>
        /// Time span for prebilling, starting from <c>bill_from</c>.
        /// </summary>
        [JsonProperty("duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duration")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsPrebillingBillUntilDurationOptions Duration { get; set; }

        /// <summary>
        /// End the prebilled period at a precise integer timestamp, starting from the Unix epoch.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Select one of several ways to pass the <c>bill_until</c> value.
        /// One of: <c>amendment_end</c>, <c>duration</c>, <c>schedule_end</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
