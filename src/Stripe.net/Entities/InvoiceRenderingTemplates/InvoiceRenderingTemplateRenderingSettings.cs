// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceRenderingTemplateRenderingSettings : StripeEntity<InvoiceRenderingTemplateRenderingSettings>
    {
        [JsonProperty("invoice_pdf")]
        [STJS.JsonPropertyName("invoice_pdf")]
        public InvoiceRenderingTemplateRenderingSettingsInvoicePdf InvoicePdf { get; set; }
    }
}
