// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationPurchaseDetailsFleetReportedBreakdownOptions : INestedOptions
    {
        /// <summary>
        /// Breakdown of fuel portion of the purchase.
        /// </summary>
        [JsonProperty("fuel")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fuel")]
#endif
        public AuthorizationPurchaseDetailsFleetReportedBreakdownFuelOptions Fuel { get; set; }

        /// <summary>
        /// Breakdown of non-fuel portion of the purchase.
        /// </summary>
        [JsonProperty("non_fuel")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("non_fuel")]
#endif
        public AuthorizationPurchaseDetailsFleetReportedBreakdownNonFuelOptions NonFuel { get; set; }

        /// <summary>
        /// Information about tax included in this transaction.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public AuthorizationPurchaseDetailsFleetReportedBreakdownTaxOptions Tax { get; set; }
    }
}
