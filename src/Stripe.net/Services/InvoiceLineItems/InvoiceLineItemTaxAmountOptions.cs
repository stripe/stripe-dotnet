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
        /// The amount on which tax is calculated, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("taxable_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("taxable_amount")]
#endif
        public long? TaxableAmount { get; set; }
    }
}
