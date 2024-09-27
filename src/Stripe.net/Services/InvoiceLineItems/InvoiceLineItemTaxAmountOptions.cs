// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceLineItemTaxAmountOptions : INestedOptions
    {
        /// <summary>
        /// The amount, in cents (or local equivalent), of the tax.
        /// </summary>
        [JsonProperty("amount")]
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
        public InvoiceLineItemTaxAmountTaxRateDataOptions TaxRateData { get; set; }

        /// <summary>
        /// The amount on which tax is calculated, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("taxable_amount")]
        public long? TaxableAmount { get; set; }
    }
}
