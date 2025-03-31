// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationFleetReportedBreakdownFuel : StripeEntity<AuthorizationFleetReportedBreakdownFuel>
    {
        /// <summary>
        /// Gross fuel amount that should equal Fuel Quantity multiplied by Fuel Unit Cost,
        /// inclusive of taxes.
        /// </summary>
        [JsonProperty("gross_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gross_amount_decimal")]
#endif
        public decimal? GrossAmountDecimal { get; set; }
    }
}
