// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCustomerBillingInvoiceRendering : StripeEntity<AccountConfigurationCustomerBillingInvoiceRendering>
    {
        /// <summary>
        /// How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.
        /// One of exclude_tax or include_inclusive_tax. include_inclusive_tax will include
        /// inclusive tax (and exclude exclusive tax) in invoice PDF amounts. exclude_tax will
        /// exclude all tax (inclusive and exclusive alike) from invoice PDF amounts.
        /// One of: <c>exclude_tax</c>, or <c>include_inclusive_tax</c>.
        /// </summary>
        [JsonProperty("amount_tax_display")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax_display")]
#endif
        public string AmountTaxDisplay { get; set; }

        /// <summary>
        /// ID of the invoice rendering template to use for future invoices.
        /// </summary>
        [JsonProperty("template")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("template")]
#endif
        public string Template { get; set; }
    }
}
