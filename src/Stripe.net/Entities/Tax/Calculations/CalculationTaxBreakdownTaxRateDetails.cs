// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class CalculationTaxBreakdownTaxRateDetails : StripeEntity<CalculationTaxBreakdownTaxRateDetails>
    {
        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The tax rate percentage as a string. For example, 8.5% is represented as <c>"8.5"</c>.
        /// </summary>
        [JsonProperty("percentage_decimal")]
        public string PercentageDecimal { get; set; }

        /// <summary>
        /// State, county, province, or region.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The tax type, such as <c>vat</c> or <c>sales_tax</c>.
        /// One of: <c>amusement_tax</c>, <c>communications_tax</c>, <c>gst</c>, <c>hst</c>,
        /// <c>igst</c>, <c>jct</c>, <c>lease_tax</c>, <c>pst</c>, <c>qst</c>, <c>rst</c>,
        /// <c>sales_tax</c>, or <c>vat</c>.
        /// </summary>
        [JsonProperty("tax_type")]
        public string TaxType { get; set; }
    }
}
