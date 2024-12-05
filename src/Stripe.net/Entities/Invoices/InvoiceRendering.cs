// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceRendering : StripeEntity<InvoiceRendering>
    {
        /// <summary>
        /// How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.
        /// </summary>
        [JsonProperty("amount_tax_display")]
        public string AmountTaxDisplay { get; set; }

        /// <summary>
        /// Invoice pdf rendering options.
        /// </summary>
        [JsonProperty("pdf")]
        public InvoiceRenderingPdf Pdf { get; set; }

        /// <summary>
        /// ID of the rendering template that the invoice is formatted by.
        /// </summary>
        [JsonProperty("template")]
        public string Template { get; set; }

        /// <summary>
        /// Version of the rendering template that the invoice is using.
        /// </summary>
        [JsonProperty("template_version")]
        public long? TemplateVersion { get; set; }
    }
}
