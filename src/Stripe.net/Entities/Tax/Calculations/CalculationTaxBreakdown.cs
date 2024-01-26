// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class CalculationTaxBreakdown : StripeEntity<CalculationTaxBreakdown>
    {
        /// <summary>
        /// The amount of tax, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Specifies whether the tax amount is included in the line item amount.
        /// </summary>
        [JsonProperty("inclusive")]
        public bool Inclusive { get; set; }

        [JsonProperty("tax_rate_details")]
        public CalculationTaxBreakdownTaxRateDetails TaxRateDetails { get; set; }

        /// <summary>
        /// The reasoning behind this tax, for example, if the product is tax exempt. We might
        /// extend the possible values for this field to support new tax rules.
        /// One of: <c>customer_exempt</c>, <c>not_collecting</c>, <c>not_subject_to_tax</c>,
        /// <c>not_supported</c>, <c>portion_product_exempt</c>, <c>portion_reduced_rated</c>,
        /// <c>portion_standard_rated</c>, <c>product_exempt</c>, <c>product_exempt_holiday</c>,
        /// <c>proportionally_rated</c>, <c>reduced_rated</c>, <c>reverse_charge</c>,
        /// <c>standard_rated</c>, <c>taxable_basis_reduced</c>, or <c>zero_rated</c>.
        /// </summary>
        [JsonProperty("taxability_reason")]
        public string TaxabilityReason { get; set; }

        /// <summary>
        /// The amount on which tax is calculated, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("taxable_amount")]
        public long TaxableAmount { get; set; }
    }
}
