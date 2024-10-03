// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceUpcomingLinesScheduleDetailsPrebillingBillUntilAmendmentEndOptions : INestedOptions
    {
        /// <summary>
        /// The position of the amendment in the <c>amendments</c> array at which prebilling should
        /// end. Indexes start from 0 and must be less than the total number of supplied amendments.
        /// </summary>
        [JsonProperty("index")]
        public long? Index { get; set; }
    }
}
