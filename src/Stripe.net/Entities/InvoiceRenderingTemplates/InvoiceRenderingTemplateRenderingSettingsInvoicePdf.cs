// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceRenderingTemplateRenderingSettingsInvoicePdf : StripeEntity<InvoiceRenderingTemplateRenderingSettingsInvoicePdf>
    {
        /// <summary>
        /// The ordered invoice PDF blocks.
        /// </summary>
        [JsonProperty("blocks")]
        [STJS.JsonPropertyName("blocks")]
        public List<InvoiceRenderingTemplateRenderingSettingsInvoicePdfBlock> Blocks { get; set; }
    }
}
