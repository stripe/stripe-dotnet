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
        /// Indicates whether displayed line item prices and amounts on invoice PDFs include
        /// inclusive tax amounts. Must be either <c>include_inclusive_tax</c> or
        /// <c>exclude_tax</c>.
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
