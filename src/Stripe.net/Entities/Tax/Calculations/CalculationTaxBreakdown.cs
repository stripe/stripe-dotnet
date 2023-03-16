// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class CalculationTaxBreakdown : StripeEntity<CalculationTaxBreakdown>
    {
        /// <summary>
        /// The amount of tax, in integer cents.
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
        /// The amount on which tax is calculated, in integer cents.
        /// </summary>
        [JsonProperty("taxable_amount")]
        public long TaxableAmount { get; set; }
    }
}
