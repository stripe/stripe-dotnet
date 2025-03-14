// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuotePreviewInvoiceRendering : StripeEntity<QuotePreviewInvoiceRendering>
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
        /// Invoice pdf rendering options.
        /// </summary>
        [JsonProperty("pdf")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pdf")]
#endif
        public QuotePreviewInvoiceRenderingPdf Pdf { get; set; }

        /// <summary>
        /// ID of the rendering template that the invoice is formatted by.
        /// </summary>
        [JsonProperty("template")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("template")]
#endif
        public string Template { get; set; }

        /// <summary>
        /// Version of the rendering template that the invoice is using.
        /// </summary>
        [JsonProperty("template_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("template_version")]
#endif
        public long? TemplateVersion { get; set; }
    }
}
