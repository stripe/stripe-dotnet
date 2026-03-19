// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationFleetReportedBreakdown : StripeEntity<AuthorizationFleetReportedBreakdown>
    {
        /// <summary>
        /// Breakdown of fuel portion of the purchase.
        /// </summary>
        [JsonProperty("fuel")]
        [STJS.JsonPropertyName("fuel")]
        public AuthorizationFleetReportedBreakdownFuel Fuel { get; set; }

        /// <summary>
        /// Breakdown of non-fuel portion of the purchase.
        /// </summary>
        [JsonProperty("non_fuel")]
        [STJS.JsonPropertyName("non_fuel")]
        public AuthorizationFleetReportedBreakdownNonFuel NonFuel { get; set; }

        /// <summary>
        /// Information about tax included in this transaction.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public AuthorizationFleetReportedBreakdownTax Tax { get; set; }
    }
}
