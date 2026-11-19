// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceRenderingTemplateRenderingSettingsInvoicePdfBlockCustomPlainTextCel : StripeEntity<InvoiceRenderingTemplateRenderingSettingsInvoicePdfBlockCustomPlainTextCel>
    {
        /// <summary>
        /// A CEL expression that returns text using the invoice context.
        /// </summary>
        [JsonProperty("cel_expression")]
        [STJS.JsonPropertyName("cel_expression")]
        public string CelExpression { get; set; }
    }
}
