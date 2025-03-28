// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemTaxAmountOptions : INestedOptions
    {
        /// <summary>
        /// The amount, in cents (or local equivalent), of the tax.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Data to find or create a TaxRate object.
        ///
        /// Stripe automatically creates or reuses a TaxRate object for each tax amount. If the
        /// <c>tax_rate_data</c> exactly matches a previous value, Stripe will reuse the TaxRate
        /// object. TaxRate objects created automatically by Stripe are immediately archived, do not
        /// appear in the line item’s <c>tax_rates</c>, and cannot be directly added to invoices,
        /// payments, or line items.
        /// </summary>
        [JsonProperty("tax_rate_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rate_data")]
#endif
        public InvoiceLineItemTaxAmountTaxRateDataOptions TaxRateData { get; set; }

        /// <summary>
        /// The reasoning behind this tax, for example, if the product is tax exempt.
        /// One of: <c>customer_exempt</c>, <c>not_collecting</c>, <c>not_subject_to_tax</c>,
        /// <c>not_supported</c>, <c>portion_product_exempt</c>, <c>portion_reduced_rated</c>,
        /// <c>portion_standard_rated</c>, <c>product_exempt</c>, <c>product_exempt_holiday</c>,
        /// <c>proportionally_rated</c>, <c>reduced_rated</c>, <c>reverse_charge</c>,
        /// <c>standard_rated</c>, <c>taxable_basis_reduced</c>, or <c>zero_rated</c>.
        /// </summary>
        [JsonProperty("taxability_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("taxability_reason")]
#endif
        public string TaxabilityReason { get; set; }

        /// <summary>
        /// The amount on which tax is calculated, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("taxable_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("taxable_amount")]
#endif
        public long? TaxableAmount { get; set; }
    }
}
