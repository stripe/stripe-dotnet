// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionPurchaseDetailsFleetReportedBreakdownNonFuel : StripeEntity<TransactionPurchaseDetailsFleetReportedBreakdownNonFuel>
    {
        /// <summary>
        /// Gross non-fuel amount that should equal the sum of the line items, inclusive of taxes.
        /// </summary>
        [JsonProperty("gross_amount_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("gross_amount_decimal")]
        public decimal? GrossAmountDecimal { get; set; }
    }
}
