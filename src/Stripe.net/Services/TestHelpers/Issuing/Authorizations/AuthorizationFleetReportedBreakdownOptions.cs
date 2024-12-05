// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationFleetReportedBreakdownOptions : INestedOptions
    {
        /// <summary>
        /// Breakdown of fuel portion of the purchase.
        /// </summary>
        [JsonProperty("fuel")]
        public AuthorizationFleetReportedBreakdownFuelOptions Fuel { get; set; }

        /// <summary>
        /// Breakdown of non-fuel portion of the purchase.
        /// </summary>
        [JsonProperty("non_fuel")]
        public AuthorizationFleetReportedBreakdownNonFuelOptions NonFuel { get; set; }

        /// <summary>
        /// Information about tax included in this transaction.
        /// </summary>
        [JsonProperty("tax")]
        public AuthorizationFleetReportedBreakdownTaxOptions Tax { get; set; }
    }
}
