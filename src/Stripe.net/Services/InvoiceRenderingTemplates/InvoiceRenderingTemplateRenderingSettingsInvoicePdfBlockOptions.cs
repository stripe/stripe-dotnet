// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceRenderingTemplateRenderingSettingsInvoicePdfBlockOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for a custom CEL text block.
        /// </summary>
        [JsonProperty("custom_plain_text_cel")]
        [STJS.JsonPropertyName("custom_plain_text_cel")]
        public InvoiceRenderingTemplateRenderingSettingsInvoicePdfBlockCustomPlainTextCelOptions CustomPlainTextCel { get; set; }

        /// <summary>
        /// A unique key within this template's blocks. Generated when omitted.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// The type of content block. Required when updating a block without a key matching an
        /// existing block in the current template version. For a matching key, omit type to retain
        /// the existing type; if supplied, it must match.
        /// One of: <c>custom_plain_text_cel</c>, <c>footer_content</c>, <c>invoice_details</c>,
        /// <c>line_items</c>, <c>parties</c>, <c>payment_remittance_instructions</c>,
        /// <c>status_and_memo</c>, <c>tax_footnotes</c>, or <c>title_and_logo</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
