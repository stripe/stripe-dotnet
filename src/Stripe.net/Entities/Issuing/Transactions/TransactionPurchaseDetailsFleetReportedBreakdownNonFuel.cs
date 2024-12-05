// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionPurchaseDetailsFleetReportedBreakdownNonFuel : StripeEntity<TransactionPurchaseDetailsFleetReportedBreakdownNonFuel>
    {
        /// <summary>
        /// Gross non-fuel amount that should equal the sum of the line items, inclusive of taxes.
        /// </summary>
        [JsonProperty("gross_amount_decimal")]
        public decimal? GrossAmountDecimal { get; set; }
    }
}
