// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CalculationLineItemTaxBreakdown : StripeEntity<CalculationLineItemTaxBreakdown>
    {
        /// <summary>
        /// The amount of tax, in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonProperty("jurisdiction")]
        [STJS.JsonPropertyName("jurisdiction")]
        public CalculationLineItemTaxBreakdownJurisdiction Jurisdiction { get; set; }

        /// <summary>
        /// Indicates whether the jurisdiction was determined by the origin (merchant's address) or
        /// destination (customer's address).
        /// One of: <c>destination</c>, <c>origin</c>, or <c>performance</c>.
        /// </summary>
        [JsonProperty("sourcing")]
        [STJS.JsonPropertyName("sourcing")]
        public string Sourcing { get; set; }

        /// <summary>
        /// Details regarding the rate for this tax. This field will be <c>null</c> when the tax is
        /// not imposed, for example if the product is exempt from tax.
        /// </summary>
        [JsonProperty("tax_rate_details")]
        [STJS.JsonPropertyName("tax_rate_details")]
        public CalculationLineItemTaxBreakdownTaxRateDetails TaxRateDetails { get; set; }

        /// <summary>
        /// The reasoning behind this tax, for example, if the product is tax exempt. The possible
        /// values for this field may be extended as new tax rules are supported.
        /// One of: <c>customer_exempt</c>, <c>not_collecting</c>, <c>not_subject_to_tax</c>,
        /// <c>not_supported</c>, <c>portion_product_exempt</c>, <c>portion_reduced_rated</c>,
        /// <c>portion_standard_rated</c>, <c>product_exempt</c>, <c>product_exempt_holiday</c>,
        /// <c>proportionally_rated</c>, <c>reduced_rated</c>, <c>reverse_charge</c>,
        /// <c>standard_rated</c>, <c>taxable_basis_reduced</c>, or <c>zero_rated</c>.
        /// </summary>
        [JsonProperty("taxability_reason")]
        [STJS.JsonPropertyName("taxability_reason")]
        public string TaxabilityReason { get; set; }

        /// <summary>
        /// The amount on which tax is calculated, in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("taxable_amount")]
        [STJS.JsonPropertyName("taxable_amount")]
        public long TaxableAmount { get; set; }
    }
}
