// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class TransactionPurchaseDetailsFleetReportedBreakdownOptions : INestedOptions
    {
        /// <summary>
        /// Breakdown of fuel portion of the purchase.
        /// </summary>
        [JsonProperty("fuel")]
        public TransactionPurchaseDetailsFleetReportedBreakdownFuelOptions Fuel { get; set; }

        /// <summary>
        /// Breakdown of non-fuel portion of the purchase.
        /// </summary>
        [JsonProperty("non_fuel")]
        public TransactionPurchaseDetailsFleetReportedBreakdownNonFuelOptions NonFuel { get; set; }

        /// <summary>
        /// Information about tax included in this transaction.
        /// </summary>
        [JsonProperty("tax")]
        public TransactionPurchaseDetailsFleetReportedBreakdownTaxOptions Tax { get; set; }
    }
}
