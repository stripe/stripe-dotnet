// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceRenderingTemplateRenderingSettingsInvoicePdfBlockCustomPlainText : StripeEntity<InvoiceRenderingTemplateRenderingSettingsInvoicePdfBlockCustomPlainText>
    {
        /// <summary>
        /// Literal text to render, preserving whitespace and newlines.
        /// </summary>
        [JsonProperty("plain_text")]
        [STJS.JsonPropertyName("plain_text")]
        public string PlainText { get; set; }
    }
}
