// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// Whether Stripe automatically computes tax on this invoice. Note that incompatible
        /// invoice items (invoice items with manually specified <a
        /// href="https://stripe.com/docs/api/tax_rates">tax rates</a>, negative amounts, or
        /// <c>tax_behavior=unspecified</c>) cannot be added to automatic tax invoices.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
        public InvoiceAutomaticTaxLiabilityOptions Liability { get; set; }
    }
}
