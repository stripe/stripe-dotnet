// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationFleetReportedBreakdown : StripeEntity<AuthorizationFleetReportedBreakdown>
    {
        /// <summary>
        /// Breakdown of fuel portion of the purchase.
        /// </summary>
        [JsonProperty("fuel")]
        public AuthorizationFleetReportedBreakdownFuel Fuel { get; set; }

        /// <summary>
        /// Breakdown of non-fuel portion of the purchase.
        /// </summary>
        [JsonProperty("non_fuel")]
        public AuthorizationFleetReportedBreakdownNonFuel NonFuel { get; set; }

        /// <summary>
        /// Information about tax included in this transaction.
        /// </summary>
        [JsonProperty("tax")]
        public AuthorizationFleetReportedBreakdownTax Tax { get; set; }
    }
}
