namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("This type is unused and is going to be removed.")]
    public class InvoiceLineItemAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// Whether Stripe automatically computes tax on this invoice. Note that incompatible
        /// invoice items (invoice items with manually specified <a
        /// href="https://stripe.com/docs/api/tax_rates">tax rates</a>, negative amounts, or
        /// <c>tax_behavior=unspecified</c>) cannot be added to automatic tax invoices.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
