// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerInvoiceSettingsRenderingOptions : StripeEntity<CustomerInvoiceSettingsRenderingOptions>
    {
        /// <summary>
        /// How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.
        /// </summary>
        [JsonProperty("amount_tax_display")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax_display")]
#endif

        public string AmountTaxDisplay { get; set; }

        /// <summary>
        /// ID of the invoice rendering template to be used for this customer's invoices. If set,
        /// the template will be used on all invoices for this customer unless a template is set
        /// directly on the invoice.
        /// </summary>
        [JsonProperty("template")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("template")]
#endif

        public string Template { get; set; }
    }
}
