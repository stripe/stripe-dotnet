// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class TransactionShippingCostTaxBreakdownTaxRateDetails : StripeEntity<TransactionShippingCostTaxBreakdownTaxRateDetails>
    {
        /// <summary>
        /// A localized display name for tax type, intended to be human-readable. For example,
        /// "Local Sales and Use Tax", "Value-added tax (VAT)", or "Umsatzsteuer (USt.)".
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The tax rate percentage as a string. For example, 8.5% is represented as "8.5".
        /// </summary>
        [JsonProperty("percentage_decimal")]
        public string PercentageDecimal { get; set; }

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
