// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// Whether Stripe automatically computes tax on this invoice. Note that incompatible
        /// invoice items (invoice items with manually specified <a
        /// href="https://docs.stripe.com/api/tax_rates">tax rates</a>, negative amounts, or
        /// <c>tax_behavior=unspecified</c>) cannot be added to automatic tax invoices.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
        [STJS.JsonPropertyName("liability")]
        public InvoiceAutomaticTaxLiabilityOptions Liability { get; set; }
    }
}
