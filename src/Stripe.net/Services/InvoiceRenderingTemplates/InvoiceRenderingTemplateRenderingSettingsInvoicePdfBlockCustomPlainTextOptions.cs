// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceRenderingTemplateRenderingSettingsInvoicePdfBlockCustomPlainTextOptions : INestedOptions
    {
        /// <summary>
        /// Literal text to render, preserving whitespace and newlines. Required, at most 10,000
        /// characters; an empty string renders no text.
        /// </summary>
        [JsonProperty("plain_text")]
        [STJS.JsonPropertyName("plain_text")]
        public string PlainText { get; set; }
    }
}
