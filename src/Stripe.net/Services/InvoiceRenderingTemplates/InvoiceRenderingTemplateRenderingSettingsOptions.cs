// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceRenderingTemplateRenderingSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Rendering settings for the invoice PDF.
        /// </summary>
        [JsonProperty("invoice_pdf")]
        [STJS.JsonPropertyName("invoice_pdf")]
        public InvoiceRenderingTemplateRenderingSettingsInvoicePdfOptions InvoicePdf { get; set; }
    }
}
