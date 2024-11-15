// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionPurchaseDetailsFleetReportedBreakdownTax : StripeEntity<TransactionPurchaseDetailsFleetReportedBreakdownTax>
    {
        /// <summary>
        /// Amount of state or provincial Sales Tax included in the transaction amount. Null if not
        /// reported by merchant or not subject to tax.
        /// </summary>
        [JsonProperty("local_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("local_amount_decimal")]
#endif

        public decimal? LocalAmountDecimal { get; set; }

        /// <summary>
        /// Amount of national Sales Tax or VAT included in the transaction amount. Null if not
        /// reported by merchant or not subject to tax.
        /// </summary>
        [JsonProperty("national_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("national_amount_decimal")]
#endif

        public decimal? NationalAmountDecimal { get; set; }
    }
}
