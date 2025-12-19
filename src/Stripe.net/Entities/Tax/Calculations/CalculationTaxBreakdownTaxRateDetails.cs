// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CalculationTaxBreakdownTaxRateDetails : StripeEntity<CalculationTaxBreakdownTaxRateDetails>
    {
        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// The amount of the tax rate when the <c>rate_type</c> is <c>flat_amount</c>. Tax rates
        /// with <c>rate_type</c> <c>percentage</c> can vary based on the transaction, resulting in
        /// this field being <c>null</c>. This field exposes the amount and currency of the flat tax
        /// rate.
        /// </summary>
        [JsonProperty("flat_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flat_amount")]
#endif
        public CalculationTaxBreakdownTaxRateDetailsFlatAmount FlatAmount { get; set; }

        /// <summary>
        /// The tax rate percentage as a string. For example, 8.5% is represented as <c>"8.5"</c>.
        /// </summary>
        [JsonProperty("percentage_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percentage_decimal")]
#endif
        public string PercentageDecimal { get; set; }

        /// <summary>
        /// Indicates the type of tax rate applied to the taxable amount. This value can be
        /// <c>null</c> when no tax applies to the location. This field is only present for TaxRates
        /// created by Stripe Tax.
        /// One of: <c>flat_amount</c>, or <c>percentage</c>.
        /// </summary>
        [JsonProperty("rate_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_type")]
#endif
        public string RateType { get; set; }

        /// <summary>
        /// State, county, province, or region (<a
        /// href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO 3166-2</a>).
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }

        /// <summary>
        /// The tax type, such as <c>vat</c> or <c>sales_tax</c>.
        /// One of: <c>admissions_tax</c>, <c>amusement_tax</c>, <c>attendance_tax</c>,
        /// <c>communications_tax</c>, <c>entertainment_tax</c>, <c>gross_receipts_tax</c>,
        /// <c>gst</c>, <c>hospitality_tax</c>, <c>hst</c>, <c>igst</c>, <c>jct</c>,
        /// <c>lease_tax</c>, <c>luxury_tax</c>, <c>pst</c>, <c>qst</c>, <c>resort_tax</c>,
        /// <c>retail_delivery_fee</c>, <c>rst</c>, <c>sales_tax</c>, <c>service_tax</c>,
        /// <c>tourism_tax</c>, or <c>vat</c>.
        /// </summary>
        [JsonProperty("tax_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_type")]
#endif
        public string TaxType { get; set; }
    }
}
