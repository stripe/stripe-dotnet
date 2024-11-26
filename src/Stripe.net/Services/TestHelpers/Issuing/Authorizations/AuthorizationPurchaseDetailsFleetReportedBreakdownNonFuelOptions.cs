// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationPurchaseDetailsFleetReportedBreakdownNonFuelOptions : INestedOptions
    {
        /// <summary>
        /// Gross non-fuel amount that should equal the sum of the line items, inclusive of taxes.
        /// </summary>
        [JsonProperty("gross_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gross_amount_decimal")]
#endif
        public decimal? GrossAmountDecimal { get; set; }
    }
}
