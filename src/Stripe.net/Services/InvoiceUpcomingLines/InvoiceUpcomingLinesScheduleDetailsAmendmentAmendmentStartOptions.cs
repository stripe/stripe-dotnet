// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceUpcomingLinesScheduleDetailsAmendmentAmendmentStartOptions : INestedOptions
    {
        /// <summary>
        /// Details of another amendment in the same array, immediately after which this amendment
        /// should begin.
        /// </summary>
        [JsonProperty("amendment_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amendment_end")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsAmendmentAmendmentStartAmendmentEndOptions AmendmentEnd { get; set; }

        /// <summary>
        /// Use the <c>end</c> time of a given discount.
        /// </summary>
        [JsonProperty("discount_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_end")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsAmendmentAmendmentStartDiscountEndOptions DiscountEnd { get; set; }

        /// <summary>
        /// A precise Unix timestamp for the amendment to start.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Select one of three ways to pass the <c>amendment_start</c>.
        /// One of: <c>amendment_end</c>, <c>discount_end</c>, <c>now</c>, <c>schedule_end</c>,
        /// <c>timestamp</c>, <c>trial_end</c>, <c>trial_start</c>, or <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}