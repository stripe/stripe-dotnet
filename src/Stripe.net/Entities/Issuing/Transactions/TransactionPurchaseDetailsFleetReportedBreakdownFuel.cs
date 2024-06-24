// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionPurchaseDetailsFleetReportedBreakdownFuel : StripeEntity<TransactionPurchaseDetailsFleetReportedBreakdownFuel>
    {
        /// <summary>
        /// Gross fuel amount that should equal Fuel Volume multipled by Fuel Unit Cost, inclusive
        /// of taxes.
        /// </summary>
        [JsonProperty("gross_amount_decimal")]
        public decimal? GrossAmountDecimal { get; set; }
    }
}
