// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class TransactionPurchaseDetailsFleetReportedBreakdownTaxOptions : INestedOptions
    {
        /// <summary>
        /// Amount of state or provincial Sales Tax included in the transaction amount. Null if not
        /// reported by merchant or not subject to tax.
        /// </summary>
        [JsonProperty("local_amount_decimal")]
        public decimal? LocalAmountDecimal { get; set; }

        /// <summary>
        /// Amount of national Sales Tax or VAT included in the transaction amount. Null if not
        /// reported by merchant or not subject to tax.
        /// </summary>
        [JsonProperty("national_amount_decimal")]
        public decimal? NationalAmountDecimal { get; set; }
    }
}
