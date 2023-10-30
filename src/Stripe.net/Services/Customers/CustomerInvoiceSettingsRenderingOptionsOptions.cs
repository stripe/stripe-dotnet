// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerInvoiceSettingsRenderingOptionsOptions : INestedOptions
    {
        /// <summary>
        /// How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.
        /// One of <c>exclude_tax</c> or <c>include_inclusive_tax</c>. <c>include_inclusive_tax</c>
        /// will include inclusive tax (and exclude exclusive tax) in invoice PDF amounts.
        /// <c>exclude_tax</c> will exclude all tax (inclusive and exclusive alike) from invoice PDF
        /// amounts.
        /// One of: <c>exclude_tax</c>, or <c>include_inclusive_tax</c>.
        /// </summary>
        [JsonProperty("amount_tax_display")]
        public string AmountTaxDisplay { get; set; }
    }
}
