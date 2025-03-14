// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceUpcomingLinesScheduleDetailsPrebillingOptions : INestedOptions
    {
        /// <summary>
        /// The end of the prebilled time period.
        /// </summary>
        [JsonProperty("bill_until")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_until")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsPrebillingBillUntilOptions BillUntil { get; set; }

        /// <summary>
        /// This is used to determine the number of billing cycles to prebill.
        /// </summary>
        [JsonProperty("iterations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iterations")]
#endif
        public long? Iterations { get; set; }
    }
}
