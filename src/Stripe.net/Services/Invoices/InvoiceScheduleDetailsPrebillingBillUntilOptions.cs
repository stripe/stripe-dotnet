// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceScheduleDetailsPrebillingBillUntilOptions : INestedOptions
    {
        /// <summary>
        /// End the prebilled period when a specified amendment ends.
        /// </summary>
        [JsonProperty("amendment_end")]
        public InvoiceScheduleDetailsPrebillingBillUntilAmendmentEndOptions AmendmentEnd { get; set; }

        /// <summary>
        /// Time span for prebilling, starting from <c>bill_from</c>.
        /// </summary>
        [JsonProperty("duration")]
        public InvoiceScheduleDetailsPrebillingBillUntilDurationOptions Duration { get; set; }

        /// <summary>
        /// End the prebilled period at a precise integer timestamp, starting from the Unix epoch.
        /// </summary>
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Select one of several ways to pass the <c>bill_until</c> value.
        /// One of: <c>amendment_end</c>, <c>duration</c>, <c>schedule_end</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
