// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceScheduleDetailsPrebillingOptions : INestedOptions
    {
        /// <summary>
        /// The end of the prebilled time period.
        /// </summary>
        [JsonProperty("bill_until")]
        public InvoiceScheduleDetailsPrebillingBillUntilOptions BillUntil { get; set; }

        /// <summary>
        /// This is used to determine the number of billing cycles to prebill.
        /// </summary>
        [JsonProperty("iterations")]
        public long? Iterations { get; set; }
    }
}
